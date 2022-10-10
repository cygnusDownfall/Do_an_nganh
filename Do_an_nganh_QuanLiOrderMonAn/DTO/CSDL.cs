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

        static MongoClient client;
        static IMongoDatabase database;
        public static void connect(string Database = "QL_order", string usename = "downfall", string password = "phammai0903")
        {
            if (client == null)
            {
                var settings = MongoClientSettings.FromConnectionString(String.Format("mongodb+srv://{0}:{1}@cluster0.6vmfiqj.mongodb.net/?retryWrites=true&w=majority",usename,password));
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                client = new MongoClient(settings);
                database = client.GetDatabase(Database);


            }

            database = client.GetDatabase(Database);

        }
        public static void testconnect2()
        {
            // Replace <connection string> with your MongoDB deployment's connection string.
            var settings = MongoClientSettings.FromConnectionString("<connection string>");
            // Set the version of the Stable API on the client.
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
        }
        public static IMongoCollection<BsonDocument> GetData(string TenBang)
        {
            //connect();
            return database.GetCollection<BsonDocument>(TenBang);
        }

        public List<MonAn> LayMenuMonAn()
        {
            connect();
            List<MonAn> monAns = new List<MonAn>();
            var data = CSDL.GetData("MonAnPhucVu");

            var filter = Builders<BsonDocument>.Filter.Empty;
            var kq = data.Find(filter).ToList();
            for (int i = 0; i < 1; i++)
            {
                monAns.Add(new MonAn(kq[i].GetValue(0).ToString(), kq[i].GetValue(1).ToString(), kq[i].GetValue(2).ToInt32()));
            }
            return monAns;
        }
    }
}
