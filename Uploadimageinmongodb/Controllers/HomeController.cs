using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uploadimageinmongodb.App_Start;
using Uploadimageinmongodb.Models;

namespace Uploadimageinmongodb.Controllers
{
    public class HomeController : Controller
    {

        private MongoDBContext dbcontext;
        private IMongoCollection<JoinNowModel> driverCollection; //stored the collection


        public HomeController()
        {
            dbcontext = new MongoDBContext();
            driverCollection = dbcontext.database.GetCollection<JoinNowModel>("CustomerDispatchRequest");
        }

        [HttpGet]
        public ActionResult JoinNow()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JoinNow(JoinNowModel join)
        {
            try
            {
                // TODO: Add insert logic here
                driverCollection.InsertOne(join);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult Dispatch()
        {
            return View();
        }

        public ActionResult DriverApp()
        {
            return View();
        }

        public ActionResult CustomerApp()
        {
            return View();
        }

        public ActionResult WebBooker()
        {
            return View();
        }
    }
}