using System;
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

        //static ICollection<BsonDocument> collection;
        public void connect(string Database = "QL_order", string usename = "downfall", string password = "phammai0903")
        {
            if (client == null)
            {
                var settings = MongoClientSettings.FromConnectionString(String.Format("mongodb+srv://{0}:{1}@cluster0.6vmfiqj.mongodb.net/?retryWrites=true&w=majority", usename, password));
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                client = new MongoClient(settings);
                database = client.GetDatabase(Database);

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
            return Query(TenBang, filter);
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
        public void Update(string TenBang, string key, string propertie, string value)
        {
            var data = GetCollection(TenBang);
            if (key != null)
            {
                var update = Builders<BsonDocument>.Update.Set(propertie, value);
                var filter = Builders<BsonDocument>.Filter.Eq("Name", key);
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


        public List<MonAn> LayMenuMonAn()
        {
            connect();
            List<MonAn> monAns = new List<MonAn>();

            var kq = GetAllInCollection("MonAnPhucVu");

            for (int i = 0; i < 1; i++)
            {
                monAns.Add(new MonAn(kq[i].GetValue(0).ToString(), kq[i].GetValue(1).ToString(), kq[i].GetValue(2).ToInt32()));
            }
            return monAns;
        }
        public List<MonAn> LayMenuMonAn(FilterDefinition<BsonDocument> filter)
        {
            connect();
            List<MonAn> monAns = new List<MonAn>();

            var kq = Query("MonAnPhucVu", filter);

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
                    Convert.ToInt32(kq[i].GetValue(2).ToString()),
                    kq[i].GetValue(3).ToLocalTime()));
            }
            return Orders;
        }
        public List<Order> LayDanhSachOrder(FilterDefinition<BsonDocument> filter)
        {
            connect();
            List<Order> Orders = new List<Order>();

            var kq = Query("MonAnPhucVu", filter);

            for (int i = 0; i < 1; i++)
            {
                Orders.Add(new Order(kq[i].GetValue(0).ToString(),
                    kq[i].GetValue(1).ToString(),
                    Convert.ToInt32(kq[i].GetValue(2).ToString()),
                    kq[i].GetValue(3).ToLocalTime()));
            }
            return Orders;
        }

    }
}
