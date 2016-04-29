using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace DropDownBandingMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var db = new TestDBEntities())
            {
                //通过Viewbag传值到视图
                ViewBag.CitiesList=db.States.ToList();
            }

            return View();
        }

        public ActionResult GetCityList(string stateId)
        {
            List<Cities> lstCities = new List<Cities>();

            int ststeID = Convert.ToInt32(stateId);

              var db = new TestDBEntities();
             // lstCities.Add(new Cities() { CityName = "test", CityId = 1, StatedId = 1});
           

                lstCities = db.Cities.Where(c => c.StatedId == ststeID).ToList<Cities>();
          

            //using System.Web.Script.Serialization;
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            //JavaScriptSerializer对象的Serialize方法序列化对象，将对象生成Json字符串
            string jsonResult = javaScriptSerializer.Serialize(lstCities);
            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }
    }
}