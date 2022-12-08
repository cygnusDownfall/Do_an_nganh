using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.Class
{
    public class apiinfo
    {
        static string apikey = "9zPhqNqiP8lgmGCtVT7syrApCy7QDvll8gw53I1vpCoJz4ZUMhxqnxzARwsp6z7s";
        public static string Key { get => apikey; }
        static string url = @"https://data.mongodb-api.com/app/data-smdtd/endpoint/";
        public static string Url { get => url; }

        static string cluster = "Cluster0";
        public static string Cluster { get => cluster; }

        static string database="QLOrderMonAn";

       
        public static string Database { get => database; }
        static string[] collections = {"Account","Order","Ban"};
        public static string[] Collections { get => collections; }

    }
}
