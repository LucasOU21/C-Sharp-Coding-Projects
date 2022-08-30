using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }



        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Quote(int Id, string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarYear, string CarMake, string CarModel, string DUI, int SpeedingTickets, string CoverageType)
        {
            if (ModelState.IsValid)
            {
               
                        int age = DateTime.Now.Year - DateOfBirth.Year;

                        // Starting Monthly base
                        double Quote = 50.0;

                        // Calculating the Age
                        if (age <= 18)
                        {
                            Quote += 100;
                        }
                        if (age >= 19 && age <= 25)
                        {
                            Quote += 50;
                        }
                        if (age > 25)
                        {
                            Quote += 25;
                        }
                        // Calculating Car Models
                        int car = DateTime.Now.Year;
                 if (CarYear < 2000) Quote += 25;

                else if (CarYear > 2015) Quote += 25;
                        {
                            Quote += 25;
                        }
                        if (CarMake == "Porsche")
                        {
                            Quote += 25;
                        }
                        if (CarMake == "Porsche" && CarModel == "911 Carrera")
                        {
                            Quote += 25;
                        }
                        // Adding SpeedingTickets
                        if (SpeedingTickets >= 1)
                        {
                            int TicketsTotal = SpeedingTickets * 10;
                            Quote += TicketsTotal;
                        }
                        // Adding DUI %
                        if (DUI == "Yes")
                        {
                            Quote *= 1.25;
                        }
                        if (CoverageType == "Full")
                        {
                            Quote *= 1.5;
                        }
                        db.Insurees.Add(insuree);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                      
                    return View(Insuree);
                }

                // GET: Insuree/Edit/5
                public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
