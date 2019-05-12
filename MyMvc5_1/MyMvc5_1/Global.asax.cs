using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyMvc5_1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //不进行添加初始数据
            //System.Data.Entity.Database.SetInitializer(new MyMvc5_1.Models.MyDbInit());


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
