using MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test.Controllers
{
    public class EmployeeR_WController : Controller
    {
        //
        // GET: /EmployeeR_W/
        public ActionResult Index()
        {
            //return View();

            var employees = from e in GetEmployeeList() orderby e.ID select e; 
            return View(employees);
        }

        //
        // GET: /EmployeeR_W/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /EmployeeR_W/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EmployeeR_W/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /EmployeeR_W/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /EmployeeR_W/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /EmployeeR_W/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /EmployeeR_W/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<EmployeeR_W> GetEmployeeList() { return new List<EmployeeR_W> { new EmployeeR_W { ID = 1, Name = "Allan", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 23 }, new EmployeeR_W { ID = 2, Name = "Carson", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 45 }, new EmployeeR_W { ID = 3, Name = "Carson", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 37 }, new EmployeeR_W { ID = 4, Name = "Laura", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 26 }, }; }
    }
}
