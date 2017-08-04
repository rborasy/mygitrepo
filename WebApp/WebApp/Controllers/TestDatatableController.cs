using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class TestDatatableController : Controller
    {
        // GET: TestDatatable
        public ActionResult Index()
        {
            List<Assessor> data = GetAssessors();
            return View(data);
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult TestSelect()
        {
            return View();
        }
        public JsonResult LoadData()
        {

            List<Assessor> data = GetAssessors();

            //return Json(data, JsonRequestBehavior.AllowGet);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        private List<Assessor> GetAssessors()
        {
            List<Assessor> data = new List<Assessor>();
            data.Add(new Assessor
            {
                Firstname = "John",
                Lastname = "Johnsons",
                GrantId = "1",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Adam",
                Lastname = "Johnsons",
                GrantId = "2",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Mary",
                Lastname = "Janes",
                GrantId = "3",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Tara",
                Lastname = "Johnsons",
                GrantId = "4",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Mike",
                Lastname = "Brown",
                GrantId = "5",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Mark",
                Lastname = "Jackson",
                GrantId = "6",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Tom",
                Lastname = "Taylor",
                GrantId = "7",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "DeJohn",
                Lastname = "James",
                GrantId = "8",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Jay",
                Lastname = "Williams",
                GrantId = "9",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Peyton",
                Lastname = "Mann",
                GrantId = "10",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Don",
                Lastname = "Johnsons",
                GrantId = "11",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Mike",
                Lastname = "Miller",
                GrantId = "12",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Mary",
                Lastname = "Baxtor",
                GrantId = "13",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Melanie",
                Lastname = "Demoss",
                GrantId = "14",
                Preferred = false
            });
            data.Add(new Assessor
            {
                Firstname = "Steve",
                Lastname = "Stoop",
                GrantId = "15",
                Preferred = false
            });

            return data;
        }
    }

    

    public class Assessor
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string GrantId { get; set; }
        public bool Preferred { get; set; }

    }

}