using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppEx2.Models;

namespace WebAppEx2.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()

        {
            List<Emp> listemp = new List<Emp>() { 
                new Emp{EId=1,EName="sam",EDesig="tester",EDOJ=DateTime.Parse("12/10/2020")},
                new Emp{EId=2,EName="gaurav",EDesig="developer",EDOJ=DateTime.Parse("10/05/2019")},
                new Emp{EId=3,EName="bhavesh",EDesig="HR",EDOJ=DateTime.Parse("02/04/2019")},
                new Emp{EId=4,EName="akhil",EDesig="manager",EDOJ=DateTime.Parse("05/04/2018")},

            };
            return View(listemp);
        }
    }
}