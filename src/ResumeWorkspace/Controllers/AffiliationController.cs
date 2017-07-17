using ResumeWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ResumeWorkspace.Controllers
{
    public class AffiliationController : Controller
    {
        private Context db = new Context();

        //Affiliation

        public ActionResult AddAffiliation()
        {
            var temp = new Affiliation() { };
            temp.StartDate = DateTime.Now;
            return View("~/Views/Affiliation/AddAffiliation.cshtml", temp);
        }

        [HttpPost]
        public ActionResult AddAffiliation(Affiliation affiliation)
        {
            //Includes PersonId for Employment Addition
            Person myPerson = db.Person.SingleOrDefault(user => user.Id == 1);

            if (ModelState.IsValid)
            {
                myPerson.AddAffiliation(affiliation);
                db.AddAffiliation(affiliation);
                return RedirectToAction("About", "Home");
            } else {
                return View("~/Views/Affiliation/AddAffiliation.cshtml", affiliation);
            }
        }

        public ActionResult EditAffiliation(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Affiliation affiliation = db.GetAffiliation((int)id);

            if (affiliation == null) { return HttpNotFound(); }

            return View("~/Views/Affiliation/EditAffiliation.cshtml", affiliation);
        }

        [HttpPost]
        public ActionResult EditAffiliation(Affiliation affiliation)
        {
            if (ModelState.IsValid)
            {
                db.EditAffiliation(affiliation);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            } else {
                return View("~/Views/Affiliation/EditAffiliation.cshtml", affiliation);
            }
        }

        public ActionResult DeleteAffiliation(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Affiliation affiliation = db.GetAffiliation((int)id);

            if (affiliation == null) { return HttpNotFound(); }

            db.DeleteAffiliation(affiliation);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}