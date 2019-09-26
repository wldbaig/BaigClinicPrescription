using Baig_Clinic.Models;
using System;
using System.Web.Mvc;

namespace Baig_Clinic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Date = DateTime.Now.ToShortDateString();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Date = DateTime.Now.ToShortDateString();
            PrescriptionViewModel model = new PrescriptionViewModel();

            for (int i = 0; i < 10; i++)
            {
                PrescriptionModel p = new PrescriptionModel();
                p.SerialNumber = i + 1;
                model.prescriptions.prescriptionDetailList.Add(p);
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(PrescriptionViewModel model)
        {
            ViewBag.Date = DateTime.Now.ToShortDateString();
            return View("Prescription", model);
        }
    }
}