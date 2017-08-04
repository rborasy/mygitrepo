using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        //https://dusted.codes/demystifying-aspnet-mvc-5-error-pages-and-error-logging
        //http://ravi-kumar-singh.blogspot.com/2014/10/how-to-use-log4net-with-aspnet-mvc-5.html
        //https://code.msdn.microsoft.com/How-to-use-Apache-log4net-0d969339
        
        readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActionResult Index()
        {
            //int x = 0;
            ////error here
            //decimal y = 100 / x;

            string mydate = string.Format("{0: MMddyyyy }", DateTime.Now);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //error here
            decimal y = GetResult();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            //error here
            decimal y = GetResult();

            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            
            filterContext.ExceptionHandled = true;

            //// Redirect on error:
            //filterContext.Result = RedirectToAction("Index", "Error");

            //// OR set the result without redirection:
            //filterContext.Result = new ViewResult
            //{
            //    ViewName = "~/Views/Error/Index.cshtml"
            //};

            logger.Info("Starting log");

            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();

            logger.Error(filterContext.Exception.ToString());

            var result = new ViewResult
            {
                ViewName = "Error"

            };

            result.ViewBag.error = "Home error";
            filterContext.Result = result;                       
        }

        private decimal GetResult()
        {
            int x = 0;
            decimal y = 100 / x;

            return y;
        }
    }
}