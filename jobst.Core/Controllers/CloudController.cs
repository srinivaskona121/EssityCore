using jobst.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace jobst.Core.Controllers
{
    public class CloudController : SurfaceController
    {
        [System.Web.Http.HttpGet]
        public ActionResult GetString()
        {
            return CurrentUmbracoPage();
        }

        public ActionResult Index()
        {
            //Todo: Redirect Logic
            return CurrentUmbracoPage();
        }

        public ActionResult Index(string name)
        {
            return PartialView(name);
        }

        public string TellMeDate()
        {
            return DateTime.Today.ToString();
        }

        [System.Web.Http.HttpGet]
        public ActionResult GetUsers()
        {
            List<UserInfo> users = new List<UserInfo>()
{
new UserInfo(){Id=1,Name="Diako",Family="Hasani"},
new UserInfo(){Id=2,Name="Sina",Family="Moradi"},
new UserInfo(){Id=3,Name="Hamid",Family="Chopani"}
};

            return Json(users, JsonRequestBehavior.AllowGet);
        }
        //[System.Web.Http.HttpPost]
        //public Action PostData()
        //{
        // return CurrentUmbracoPage();
        //}
    }
}
