using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Uploadimageinmongodb.App_Start
{
    public class MongoDBContext
    {
        public IMongoDatabase database; //The IMongoDatabase type exposes the following members.

        public MongoDBContext()
        {
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["mongoDBHost"]);
            database = mongoClient.GetDatabase(ConfigurationManager.AppSettings["mongoDBName"]);
        }
    }
}