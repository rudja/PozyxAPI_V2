using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PozyxAPI_V2.Models
{
    public class Localization
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Products
    {
        public int id_product { get; set; }
        public string category { get; set; }
        public string short_name { get; set; }
        public string long_name { get; set; }
        public string photo_id { get; set; }
        public int substitut_id { get; set; }
        public string format { get; set; }
        public Localization localization { get; set; }
        public int driveway { get; set; }
        public int location { get; set; }
        public int quantity { get; set; }
    }


    public class Orders
    {
        public ObjectId Id { get; set; }
        public List<Products> products { get; set; }
    }
}