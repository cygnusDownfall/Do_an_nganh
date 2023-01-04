using System;
using System.Collections.Generic;
//using System.Net.Http;
using Newtonsoft.Json;
using Do_an_nganh_QuanLiOrderMonAn.Class;
using RestSharp;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    public class CSDL
    {
        string[] collectionwithBlock = { "Order" };
        CSDL() { }

        public static CSDL instance = new CSDL();

        public async Task<string> RestRequest(string route, string body) //dung cho endpoint custom
        {
            var client = new RestClient(apiinfo.Url + route);
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Access-Control-Request-Headers", "*");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("api-key", apiinfo.Key);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.PostAsync(request);
            MessageBox.Show(response.Content.ToString());
            return response.Content.ToString();
        }
        public async Task<string> SendToMongoAPI(string CollectionName, string route, string cmd)
        {
            var body = @"{" + "\n" +
             @" ""dataSource"":""" + apiinfo.Cluster + @"""," + "\n" +
            @" ""database"":""" + apiinfo.Database + @"""," + "\n" +
            @" ""collection"":""" + CollectionName + @"""," + "\n" +
            cmd + "\n" +
            @"" +
            @"}";

            return await RestRequest(route, body);
        }



        #region query,insert,update,remove

        public async Task<List<T>> Query<T>(string CollectionName, string filter = "", string id = "")
        {
            //tim theo ID tu danh sach da dc loc qua filter
            if (id != "" && (!filter.Contains("id")))
            {
                if (filter != "")
                {
                    filter += ",\"id\":\"" + id + "\"";
                }
                else
                {
                    filter += "\"id\":\"" + id + "\"";
                }
            }

            // tim tat ca  theo dieu kien
            string res;
            if (collectionwithBlock.Contains(CollectionName))
            {
                res = await SendToMongoAPI(CollectionName, "find", " \"filter\":{" + filter + "}");//ch xong
            }
            else
            {
                res = await SendToMongoAPI(CollectionName, "data/v1/action/find", " \"filter\":{" + filter + "}");
            }
            string s = code.documentToJsonarray(res);
            return JsonConvert.DeserializeObject<List<T>>(s);
        }

        #region insert
        public async void Insert<T>(string CollectionName, T value)
        {
            if (collectionwithBlock.Contains(CollectionName))
            {
                addBlock(CollectionName, JsonConvert.SerializeObject(value));
            }
            else
            {
                await SendToMongoAPI(CollectionName, "data/v1/action/insertOne", "\"document\":" + JsonConvert.SerializeObject(value));
            }
        }
        public async void Insert<T>(string CollectionName, List<T> values)
        {
            if (collectionwithBlock.Contains(CollectionName))
            {
                for (int i = 0, length = values.Count; i < length; i++)
                {
                    addBlock(CollectionName, JsonConvert.SerializeObject(values[i]));
                }

            }
            else
            {
                await SendToMongoAPI(CollectionName, "data/v1/action/insertMany", "\"document\":" + JsonConvert.SerializeObject(values));
            }

        }
        #endregion
        #region update
        public void UpdateOne<T>(string CollectionName, T value) where T : Block
        {
            if (collectionwithBlock.Contains(CollectionName))
            {
                string id = "\"id\":\"" + value.id + "\"";
                addBlock(CollectionName, JsonConvert.SerializeObject(value), id);
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
                    id = "\"id\":\"" + x.id + "\"";
                    addBlock(CollectionName, JsonConvert.SerializeObject(x), id);
                }

            }
            else
            {
                MessageBox.Show("Loi update Block");
            }

        }
        public async void UpdateOne(string CollectionName, string search, string searchvalue, string setpropertie, string value)
        {
            if (collectionwithBlock.Contains(CollectionName))
            {
                return;
            }
            if (searchvalue != null)
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

                string filter = "\"filter\":{\"" + search + "\":\"" + searchvalue + "\"}";
                string cmd = filter + "," + update;
                await SendToMongoAPI(CollectionName, "data/v1/action/updateOne", cmd);

            }
        }
        public async Task<int> UpdateMany(string CollectionName, string filter, string setpropertie, string value)
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
                filter = "\"filter\":{" + filter + "}";
                string cmd = filter + "," + update;
                string res = await SendToMongoAPI(CollectionName, "data/v1/action/updateMany", cmd);
                return code.ResupdateToIntRowsImpact(res);
            }
            return 0;
        }
        #endregion
        #region remove
        public async Task<int> RemoveAll(string CollectionName, string filter = "")
        {
            string res;
            if (collectionwithBlock.Contains(CollectionName))
            {
                res = await SendToMongoAPI(CollectionName, "deleteBlock", "");
            }
            else
            {
                if (filter != null)
                {
                    filter = "\"filter\":{" + filter + "}";
                    string cmd = filter;
                    res = await SendToMongoAPI(CollectionName, "data/v1/action/deleteMany", cmd);
                    return code.ResupdateToIntRowsImpact(res);
                }
            }

            return 0;
        }
        public async Task<bool> RemoveOne(string CollectionName, string filter = "")
        {
            string res="";
            if (collectionwithBlock.Contains(CollectionName))
            {
                res = await SendToMongoAPI(CollectionName, "deleteBlock", "");//ch xong
            }
            else
            {
                if (filter != null)
                {
                    filter = "\"filter\":{" + filter + "}";
                    string cmd = filter;
                    res = await SendToMongoAPI(CollectionName, "data/v1/action/deleteOne", cmd);
                }
            }
            if (code.ResupdateToIntRowsImpact(res)==0)
            {
                return false;
            }
            return true;
        }
        public async void RemoveOne<T>(string CollectionName, T value) where T : Block
        {
            string res;
            if (collectionwithBlock.Contains(CollectionName))
            {
                res = await SendToMongoAPI(CollectionName, "deleteBlock", "\"id\":\"" + value.id + "\"");//ch xong
            }
            else
            {
                MessageBox.Show("dung sai ham r cha");
            }
        }
        #endregion

        #endregion
        #region Block

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
        public T findBlock<T>(string collection, string id, int go)
        {
            string res = SendToMongoAPI(collection, "findBlock", "").Result;
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
