﻿using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;



namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    class CSDL
    {
        CSDL()
        {
            connect();
        }

        public static CSDL instance = new CSDL();
        


        MongoClient client;
        IMongoDatabase database;

      
        public void connect(string Database = "QLOrderMonAn")
        {
            if (client == null)
            {

                var settings = MongoClientSettings.FromConnectionString("mongodb+srv://downfall:downfall@cluster0.rrzospc.mongodb.net/?retryWrites=true&w=majority");
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                client = new MongoClient(settings);
                var database = client.GetDatabase(Database);
            }

            database = client.GetDatabase(Database);

        }
        public IMongoCollection<BsonDocument> GetCollection(string TenBang)
        {
            return database.GetCollection<BsonDocument>(TenBang);
        }
        #region query,insert,update,remove
        public List<BsonDocument> Query(string TenBang, FilterDefinition<BsonDocument> filter)
        {
            var data = GetCollection(TenBang);
            var kq = data.Find(filter).ToList();
            return kq;
        }
        public List<BsonDocument> GetAllInCollection(string TenBang)
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            try
            {
                var res=Query(TenBang, filter);
                return Query(TenBang, filter);
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                return null;
            }
            
        }

        public void Insert(string TenBang, BsonDocument elements)
        {
            var data = GetCollection(TenBang);
            data.InsertOne(elements);
        }
        public void Insert(string TenBang, BsonDocument[] elements)
        {
            var data = GetCollection(TenBang);
            data.InsertMany(elements);
        }
        public void Update<T>(string TenBang, string name, string propertie, T value)
        {
            var data = GetCollection(TenBang);
            if (name != null)
            {
                var update = Builders<BsonDocument>.Update.Set(propertie, value);
                var filter = Builders<BsonDocument>.Filter.Eq("Name",name );
                data.UpdateOne(filter, update);
            }

        }
        public void UpdateMany(string TenBang, FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
        {
            var data = GetCollection(TenBang);

            data.UpdateMany(filter, update);
        }
        public void Remove(string TenBang, FilterDefinition<BsonDocument> filter)
        {
            var data = GetCollection(TenBang);
            if (filter != null)
            {
                data.DeleteMany(filter);
            }
        }
        public void Remove(string TenBang, string key)
        {
            var data = GetCollection(TenBang);
            var filter = Builders<BsonDocument>.Filter.Eq("Name", key);
            data.DeleteMany(filter);

        }
        public void Remove(string TenBang, string[] keys)
        {
            var data = GetCollection(TenBang);
            var filter = Builders<BsonDocument>.Filter.In("Name", keys);
            data.DeleteMany(filter);

        }
        #endregion

        #region Ham chuc nang co su dung thu vien MongoDB de o day cac class QL k can goi lai thu vien nay
        public List<MonAn> LayMenuMonAn()
        {
            connect();
            List<MonAn> monAns = new List<MonAn>();

            var kq = GetAllInCollection("MonAn");
            if(kq == null || kq.Count == 0) { return null; }

            for (int i = 0,n=kq.Count; i < n; i++)
            {
                monAns.Add(new MonAn(kq[i].GetValue(0).ToString(), kq[i].GetValue(1).ToString(), kq[i].GetValue(2).ToInt32()));
            }
            return monAns;
        }
        public List<MonAn> LayMenuMonAn(FilterDefinition<BsonDocument> filter)
        {
            connect();
            List<MonAn> monAns = new List<MonAn>();

            var kq = Query("MonAn", filter);

            for (int i = 0; i < 1; i++)
            {
                monAns.Add(new MonAn(kq[i].GetValue(0).ToString(), kq[i].GetValue(1).ToString(), kq[i].GetValue(2).ToInt32()));
            }
            return monAns;
        }
        public List<Order> LayDanhSachOrder()
        {
            connect();
            List<Order> Orders = new List<Order>();

            var kq = GetAllInCollection("Order");

            for (int i = 0; i < 1; i++)
            {
                Orders.Add(new Order(kq[i].GetValue(0).ToString(),
                    kq[i].GetValue(1).ToString(),
                    kq[i].GetValue(2).AsInt32,
                    kq[i].GetValue(3).ToLocalTime()));
            }
            return Orders;
        }
        public List<Order> LayDanhSachOrder(FilterDefinition<BsonDocument> filter)
        {
            connect();
            List<Order> Orders = new List<Order>();

            var kq = Query("MonAn", filter);

            for (int i = 0; i < 1; i++)
            {
                Orders.Add(new Order(kq[i].GetValue(0).ToString(),
                    kq[i].GetValue(1).ToString(),
                   kq[i].GetValue(2).AsInt32,
                    kq[i].GetValue(3).ToLocalTime()));
            }
            return Orders;
        }

        public bool SearchAccount(string name,string pass, bool isadmin)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Name", name);
            var ds = Query("Account",filter);
            if(ds.Count ==0 || ds == null || ds[0].GetValue(4).AsBoolean|| (ds[0].GetValue(3).AsBoolean!=isadmin)) 
            { return false; }
            try
            {
                BsonDocument bson = ds[0];
                if (bson.GetValue(2).AsString != pass) { return false; }    
                Account.instance.init(bson.GetValue(1).AsString, bson.GetValue(2).AsString,
                    bson.GetValue(3).AsBoolean);

            }
            catch (Exception)
            {
                return false;
            } 
            return true;
        }
        public List<string> danhsachban()
        {
            List<string> strings = new List<string>();
            List<BsonDocument> bsonElements = GetAllInCollection("Ban");
            for (int i = 0,n=bsonElements.Count; i < n; i++)
            {
                strings.Add(bsonElements[i].GetValue(1).AsInt32.ToString());
            }
            return strings;
        }
        #endregion
    }
}
