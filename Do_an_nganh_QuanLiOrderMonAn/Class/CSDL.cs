﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Do_an_nganh_QuanLiOrderMonAn.Class;
using RestSharp;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    class CSDL
    {
        string[] collectionwithBlock = { "Order" };
        CSDL()
        {

        }

        public static CSDL instance = new CSDL();


        HttpClient httpClient = new HttpClient();

        public async Task<string> Rest(string collection, string route, string cmd)
        {
            var body = @"{" + "\n" +
            @" ""collection"":""" + collection + @"""," + "\n" +
            @" ""database"":""" + apiinfo.Database + @"""," + "\n" +
            @" ""dataSource"":""" + apiinfo.Cluster + @"""," + "\n" +
            cmd + "\n" +
            @"" + "\n" +
            @"}";

            return await RestRequest(route, body);
        }



        #region query,insert,update,remove

        public async Task<List<T>> Query<T>(string CollectionName, string filter = "", string id = "")
        {
            string res;
            if (collectionwithBlock.Contains(CollectionName))
            {
                id = "\"id\":\"" + id + "\"";
                res = await Rest(CollectionName, "find", id);//ch xong
            }
            else
            {

                res = await Rest(CollectionName, "data/v1/find", " \"filter\"  :{" + filter + "}");
            }
            string s = code.documentToJsonarray(res);
            return JsonConvert.DeserializeObject<List<T>>(s);
        }

        #region insert
        public async void Insert<T>(string CollectionName, T value) where T : Block
        {
            if (collectionwithBlock.Contains(CollectionName))
            {
                addBlock(CollectionName, JsonConvert.SerializeObject(value));
            }
            else
            {
                await Rest(CollectionName, "data/v1/insertOne", "\"document\":" + JsonConvert.SerializeObject(value));
            }

        }
        public async void Insert<T>(string CollectionName, List<T> values)
        {
            await Rest(CollectionName, "insertMany", "\"document\":" + JsonConvert.SerializeObject(values));
        }
        #endregion
        #region update
        public void UpdateOne<T>(string CollectionName, T value)where T:Block
        {
            if (collectionwithBlock.Contains(CollectionName))
            {
                string id = "\"id\":\"" + value.id + "\"";
                addBlock(CollectionName, JsonConvert.SerializeObject(value),id);
            }
            else
            {
                MessageBox.Show("Loi update Block");
            }
        }
        public void UpdateOne<T>(string CollectionName, List<T> value) where T : Block
        {
            if (collectionwithBlock.Contains(CollectionName))
            {
                string id;
                foreach (var x in value)
                {
                    id= "\"id\":\"" + x.id + "\"";
                    addBlock(CollectionName, JsonConvert.SerializeObject(x),id);
                }
                
            }
            else
            {
                MessageBox.Show("Loi update Block");
            }

        }
        public async void UpdateOne(string CollectionName, string search, string name, string setpropertie, string value)
        {
            if (name != null)
            {
                string update;
                try
                {
                    int val = Convert.ToInt32(value);
                    update = "\"update\" : { \"$set\" : { \"" + setpropertie + "\": " + val + " }}";
                }
                catch
                {
                    update = "\"update\" : { \"$set\" : { \"" + setpropertie + "\": \"" + value + "\" }}";
                }

                string filter = "\"filter\":{\"" + search + "\":\"" + name + "\"}";
                string cmd = filter + "," + update;
                await Rest(CollectionName, "updateOne", cmd);

            }
        }
        public async Task<int> UpdateMany(string CollectionName, string filt, string setpropertie, string value)
        {
            if (value != null)
            {
                string update;
                try
                {
                    int val = Convert.ToInt32(value);
                    update = "\"update\" : { \"$set\" : { \"" + setpropertie + "\": " + val + " }}";
                }
                catch
                {
                    update = "\"update\" : { \"$set\" : { \"" + setpropertie + "\": \"" + value + "\" }}";
                }
                string filter = "\"filter\":{" + filt + "}";
                string cmd = filter + "," + update;
                string res = await Rest(CollectionName, "updateMany", cmd);
                return code.ResupdateToIntRowsImpact(res);
            }
            return 0;
        }
        #endregion
        #region remove
        public async Task<int> RemoveAll(string CollectionName, string filt = "")
        {
            string res;
            if (collectionwithBlock.Contains(CollectionName))
            {
                res = await Rest(CollectionName, "deleteBlock", "");
            }
            else
            {
                if (filt != null)
                {
                    string filter = "\"filter\":{" + filt + "}";
                    string cmd = filter;
                    res = await Rest(CollectionName, "deleteMany", cmd);
                    return code.ResupdateToIntRowsImpact(res);
                }
            }
           
            return 0;
        }
        public async void RemoveOne(string CollectionName, string filt = "")
        {
            string res;
            if (collectionwithBlock.Contains(CollectionName))
            {
                res = await Rest(CollectionName, "deleteBlock", "");//ch xong
            }
            else
            {
                if (filt != null)
                {
                    string filter = "\"filter\":{" + filt + "}";
                    string cmd = filter;
                    await Rest(CollectionName, "deleteOne", cmd);
                }
            }
           
        }
        public async void RemoveOne<T>(string CollectionName,T value)where T:Block
        {
            string res;
            if (collectionwithBlock.Contains(CollectionName))
            {
                res = await Rest(CollectionName, "deleteBlock", "\"id\":\"" + value.id + "\"");//ch xong
            }
            else
            {
                MessageBox.Show("dung sai ham r cha");
            }
        }
        #endregion

        #endregion
        #region Block
        public async Task<string> RestRequest(string route, string body) //dung cho endpoint custom
        {
            var client = new RestClient(apiinfo.Url + route);
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Access-Control-Request-Headers", "*");
            request.AddHeader("api-key", apiinfo.Key);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.PostAsync(request);
            MessageBox.Show(response.Content.ToString());
            return response.Content.ToString();
        }
        public void addBlock(string collection, string bodydoc, string id = "")
        {
            if (id != "")
            {
                id = "\"id\":\"" + id + "\"";
            }
            string body = "{ \n \"database\" : \"QLOrderMonAn\"," +
                " \"collection\" : \"" + collection + "\",  " +
                id +
                " \"bodydoc\" : \"" + bodydoc + " \",\n}";

            string res = RestRequest(apiinfo.Url + "addBlock", body).Result;
        }
        public  T findBlock<T>(string collection, string id,int go)
        {
            string res =Rest(collection, "findBlock", "").Result;
            return JsonConvert.DeserializeObject<T>(res);
        }
        #endregion

        #region Ham ket noi truc tiep khong dung nua
        //public IMongoCollection<BsonDocument> GetCollection(string CollectionName)
        //{
        //    return database.GetCollection<BsonDocument>(CollectionName);
        //}

        //public List<BsonDocument> Query(string CollectionName, FilterDefinition<BsonDocument> filter)
        //{
        //    var data = GetCollection(CollectionName);
        //    var kq = data.Find(filter).ToList();
        //    return kq;
        //}

        //public void connect(string Database = "QLOrderMonAn")
        //{
        //    if (client == null)
        //    {
        //        var settings = MongoClientSettings.FromConnectionString("mongodb+srv://downfall:downfall@cluster0.rrzospc.mongodb.net/?retryWrites=true&w=majority");
        //        settings.ServerApi = new ServerApi(ServerApiVersion.V1);
        //        client = new MongoClient(settings);
        //        var database = client.GetDatabase(Database);
        //    }
        //    database = client.GetDatabase(Database);
        //}

        //public void Remove(string CollectionName, string key)
        //{
        //    var data = GetCollection(CollectionName);
        //    var filter = Builders<BsonDocument>.Filter.Eq("Name", key);
        //    data.DeleteMany(filter);

        //}
        //public void Remove(string CollectionName, string[] keys)
        //{
        //    var data = GetCollection(CollectionName);
        //    var filter = Builders<BsonDocument>.Filter.In("Name", keys);
        //    data.DeleteMany(filter);
        //}

        //public List<MonAn> LayMenuMonAn(FilterDefinition<BsonDocument> filter)
        //{
        //    connect();
        //    List<MonAn> monAns = new List<MonAn>();

        //    var kq = Query("MonAn", filter);

        //    for (int i = 0; i < 1; i++)
        //    {
        //        monAns.Add(new MonAn( kq[i].GetValue(1).ToString(), kq[i].GetValue(2).ToInt32(), kq[i].GetValue(3).AsString));
        //    }
        //    return monAns;
        //}

        //public List<Order> LayDanhSachOrder(FilterDefinition<BsonDocument> filter)
        //{
        //    connect();
        //    List<Order> Orders = new List<Order>();

        //    var kq = Query("MonAn", filter);

        //    for (int i = 0; i < 1; i++)
        //    {
        //        Orders.Add(new Order(kq[i].GetValue(1).ToString(),
        //           kq[i].GetValue(2).AsInt32,
        //            kq[i].GetValue(3).ToLocalTime()));
        //    }
        //    return Orders;
        //}

        //public bool SearchAccount(string name, string pass, bool isadmin)
        //{
        //    var filter = Builders<BsonDocument>.Filter.Eq("Name", name);
        //    var ds = Query("Account", filter);
        //    if (ds.Count == 0 || ds == null || ds[0].GetValue(4).AsBoolean || (ds[0].GetValue(3).AsBoolean != isadmin))
        //    { return false; }
        //    try
        //    {
        //        BsonDocument bson = ds[0];
        //        if (bson.GetValue(2).AsString != pass) { return false; }
        //        Account.instance.init(bson.GetValue(1).AsString, bson.GetValue(2).AsString,
        //            bson.GetValue(3).AsBoolean);

        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        #endregion

        #region k con dung
        //MongoClient client;
        //IMongoDatabase database;



        //public void Post<T>(string collection, T obj, string cmd = "insertOne") 
        //{


        //    string head = String.Format("{0}/action/{1}", apiinfo.Url, cmd);
        //    /*string body1 = String.Format("--header 'Content-Type: application/json' \\\r\n  --header 'Access-Control-Request-Headers: *' \\\r\n --header \"api-key:{0}\" \\\r\n  "
        //        , apiinfo.Key);*/
        //    string body2 = " '{\r\n   \"dataSource\":\"" + apiinfo.Cluster + "\",\r\n   ";
        //    //string body2 = " '{\r\n   \"dataSource\":\" " + apiinfo.Cluster + " \",\r\n   ";
        //    string body3 = " \"database\":\"" + apiinfo.Database + "\",\r\n   \"collection\":\"" + collection + "\",\r\n ";

        //    string p = body2 + body3 + " \"document\" :" + JsonConvert.SerializeObject(obj) + "}'";
        //    StringContent content = new StringContent(p);

        //    content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        //    //content.Headers.Add(p);
        //    content.Headers.Add("Access-Control-Request-Headers", "*");
        //    content.Headers.Add("api-key", apiinfo.Key);

        //    var x = httpClient.PostAsync(head, content);
        //    System.Windows.Forms.MessageBox.Show(x.Result.ToString());
        //}


        #endregion

    }
}
