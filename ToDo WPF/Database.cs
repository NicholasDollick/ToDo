using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace ToDo_WPF
{
    class Database
    {
        static void main(string [] args)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("startup");
            var collect = database.GetCollection<BsonDocument>("employee");
        }
    }
}
