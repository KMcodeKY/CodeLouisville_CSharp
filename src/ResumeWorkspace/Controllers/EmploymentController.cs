﻿using ResumeWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ResumeWorkspace.Controllers
{
    public class EmploymentController : Controller
    {
        private Context db = new Context();

        //Employment

        public ActionResult AddEmployment()
        {
            var temp = new Employment() { };
            temp.StartDate = DateTime.Now;
            return View("~/Views/Employment/AddEmployment.cshtml", temp);
        }

        [HttpPost]
        public ActionResult AddEmployment(Employment employment)
        {
            //Includes PersonId for Employment Addition
            Person myPerson = db.Person.SingleOrDefault(user => user.Id == 1);

            if (ModelState.IsValid)
            {
                myPerson.AddEmployment(employment);
                db.AddEmployment(employment);
                return RedirectToAction("About", "Home");
            } else {
                return View("~/Views/Employment/AddEmployment.cshtml", employment);
            }
        }

        public ActionResult EditEmployment(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Employment employment = db.GetEmployment((int)id);

            if (employment == null) { return HttpNotFound(); }

            return View("~/Views/Employment/EditEmployment.cshtml", employment);
        }

        [HttpPost]
        public ActionResult EditEmployment(Employment employment)
        {

            if (ModelState.IsValid)
            {
                db.EditEmployment(employment);
                db.SaveChanges();
                return RedirectToAction("About", "Home");
            } else {
                return View("~/Views/Employment/EditEmployment.cshtml", employment);
            }
        }

        public ActionResult DeleteEmployment(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Employment employment = db.GetEmployment((int)id);

            if (employment == null) { return HttpNotFound(); }

            return View("~/Views/Employment/DeleteEmployment.cshtml", employment);
        }

        [HttpPost]
        public ActionResult DeleteEmployment(Employment employment)
        {
            db.DeleteEmployment(employment);
            db.SaveChanges();
            return RedirectToAction("About", "Home");
        }

        public ActionResult AddAccomplishment(int? id)
        {
            var temp = new Accomplishment() { };
            //Includes PositionId for Accomplishment Addition
            Position myPosition = db.Position.SingleOrDefault(user => user.Id == id);
            myPosition.AddAccomplishment(temp);

            db.AddAccomplishment(temp);
            return RedirectToAction("EditPosition", "Employment", new { id = temp.PositionId });
        }

        public ActionResult DeleteAccomplishment(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Accomplishment accomplishment = db.GetAccomplishment((int)id);

            if (accomplishment == null) { return HttpNotFound(); }

            var temp = accomplishment.PositionId;

            db.DeleteAccomplishment(accomplishment);
            db.SaveChanges();

            return RedirectToAction("EditPosition", "Employment", new { id = temp });
        }

        //Contact

        public ActionResult AddContact(int? id)
        {
            var temp = new Contact() { };
            temp.Name = "Enter Name Here";
            //Includes PositionId for Contact Addition
            Position myPosition = db.Position.SingleOrDefault(user => user.Id == id);
            myPosition.AddContact(temp);

            db.AddContact(temp);
            return RedirectToAction("EditPosition", "Employment", new { id = temp.PositionId });
        }

        public ActionResult DeleteContact(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

           Contact contact = db.GetContact((int)id);

            if (contact == null) { return HttpNotFound(); }

            var temp = contact.PositionId;

            db.DeleteContact(contact);
            db.SaveChanges();

            return RedirectToAction("EditPosition", "Employment", new { id = temp });
        }

        //Position

        public ActionResult AddPosition(int? id)
        {
            var temp = new Position() {};
            temp.StartDate = DateTime.Now;
            temp.Title = "Enter Title Here";

            //Includes EmploymentId for Position Addition
            Employment myEmployment = db.Employment.SingleOrDefault(user => user.Id == id);
            myEmployment.AddPosition(temp);
            db.AddPosition(temp);
            return View("~/Views/Employment/EditPosition.cshtml", temp);
        }

        public ActionResult EditPosition(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Position position = db.GetPosition((int)id);

            if (position == null) { return HttpNotFound(); }

            return View("~/Views/Employment/EditPosition.cshtml", position);
        }

        [HttpPost]
        public ActionResult EditPosition(Position position)
        {
            if (ModelState.IsValid)
            {
                db.EditPosition(position);
                db.SaveChanges();
                return RedirectToAction("About", "Home");
            } else {
                return View("~/Views/Employment/EditPosition.cshtml", position);
            }
        }

        public ActionResult DeletePosition(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Position position = db.GetPosition((int)id);

            if (position == null) { return HttpNotFound(); }

            return View("~/Views/Employment/DeletePosition.cshtml", position);
        }

        [HttpPost]
        public ActionResult DeletePosition(Position position)
        {
            db.DeletePosition(position);
            db.SaveChanges();
            return RedirectToAction("About", "Home");
        }

    }
}