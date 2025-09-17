using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ProjectCreator.DB
{
    internal class DB
    {

        public static string? URI()
        {
            return "mongodb://localhost:27017";
        }

        public static async Task GetDB(string data)
        {

            string? URL = DB.URI();
            var client = new MongoClient(URL);

            var DB1 = client.GetDatabase("PROJECT");

            var coll = DB1.GetCollection<BsonDocument>("Project_Name");
            await coll.InsertOneAsync(new BsonDocument("Name", data));

        }

    }
}
