using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
// Replace the uri string with your MongoDB deployment's connection string.


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    class CSDL
    {
        MongoClient client;
        IMongoDatabase database;
        public void connect(string Database="QL_order",string usename = "downfall", string password = "phammai0903#")
        {
              client = new MongoClient(
              string.Format("mongodb+srv://{0}:{1}@<cluster-address>/test?w=majority", usename, password)
           );
            database = client.GetDatabase(Database);

        }
        public void testconnect2()
        {
            // Replace <connection string> with your MongoDB deployment's connection string.
            var settings = MongoClientSettings.FromConnectionString("<connection string>");
            // Set the version of the Stable API on the client.
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
        }
        public BsonDocument GetData(string TenBang)
        {
            connect();
           // return database.GetCollection<BsonDocument>(TenBang);
        }

    }
}
