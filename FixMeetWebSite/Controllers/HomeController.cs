using FixMeetWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary;
using static ClassLibrary.BusinessLogic.SupplierProcessor;

namespace FixMeetWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewSuppliers()
        {
            ViewBag.Message = "Suppliers List";

            var data = LoadSuppliers();
            List<Supplier> suppliers = new List<Supplier>();
            foreach(var row in data)
            {
                suppliers.Add(new Supplier
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    Email = row.Email,
                    ConfirmEmail=row.Email,
                    UserName = row.UserName,
                    Radius = row.Radius/*,
                    Address = row.Address.City, 
                    Category =row.Category.CategoryName*/
                });
            }

            return View(suppliers);
        }


        public ActionResult SignUp()
        {
            ViewBag.Message = "Supplier Sign Up";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(Supplier model)
        {
            if (ModelState.IsValid)
            {
                int recordCreated=CreateSupplier(model.FirstName, 
                    model.LastName, 
                    model.Email, 
                    model.UserName, 
                    model.Radius/*,
                    model.Address,
                    model.Category*/);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}