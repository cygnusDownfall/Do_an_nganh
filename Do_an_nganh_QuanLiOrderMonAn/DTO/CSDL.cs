using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
// Replace the uri string with your MongoDB deployment's connection string.


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    class CSDL
    {
        public void testconnect()
        {
            var client = new MongoClient(
               "mongodb+srv://<username>:<password>@<cluster-address>/test?w=majority"
           );
            var database = client.GetDatabase("test");

        }
        public void testconnect2()
        {
            // Replace <connection string> with your MongoDB deployment's connection string.
            var settings = MongoClientSettings.FromConnectionString("<connection string>");
            // Set the version of the Stable API on the client.
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
        }

    }
}
