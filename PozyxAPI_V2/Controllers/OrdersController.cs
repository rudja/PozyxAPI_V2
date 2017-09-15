using MongoDB.Bson;
using MongoDB.Driver;
using PozyxAPI_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PozyxAPI_V2.Controllers
{
    public class OrdersController : ApiController
    {
        // GET: api/Orders
        //Get the first command into the list 
        //Warning! Do a last query to get more information about the product into the JSON
        public async Task<Orders> GetOrder()
        {
            IMongoCollection<Orders> collection;
            var connectionString = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionString);
            var db = client.GetDatabase("EasyCommandDB");
            collection = db.GetCollection<Orders>("Orders");

            List<Orders> result = new List<Orders>();
            var filter = new BsonDocument();
            using (var cursor = await collection.FindAsync(filter))
            {
                return cursor.FirstOrDefault();
            }
        }

        //GET: api/Connection
        //public bool GetConnection()
        //{

        //}

        //GET: api/Substitute/{product_id}
        //public bool GetSubstitute()
        //{

        //}


    }
}
