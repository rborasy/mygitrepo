using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CKEditorController : Controller
    {
        // GET: CKEditor
        public ActionResult Index()
        {
            EmailModel model = new EmailModel();
            model.Subject = "Newsletter";
            model.Message = "<html><head><title>Newsletter</title></head> <body>hello </body></html>";
            return View(model);
        }
    }
}