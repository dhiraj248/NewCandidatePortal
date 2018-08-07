using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewCandidatePortal.Models;

namespace NewCandidatePortal.Controllers
{
    public class HomeController : Controller
    {
        EmploymentContext objDb = new EmploymentContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult CreateEmploymentData()
        {            
            return View();
        }
        [HttpPost]
        public ViewResult CreateEmploymentData(EmploymentData EmpData)
        {
            try
            {
                objDb.EmploymentDatas.Add(EmpData);
                objDb.SaveChanges();
                return View("success");
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("error");                
            }
            

        }

    }
}