using ResumeWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ResumeWorkspace.Controllers
{
    public class SkillController : Controller
    {
        private Context db = new Context();

        //Affiliation

        public ActionResult AddSkill()
        {
            var temp = new Skill() { };
            return View("~/Views/Skill/AddSkill.cshtml", temp);
        }

        [HttpPost]
        public ActionResult AddSkill(Skill skill)
        {
            //Includes PersonId for Employment Addition
            Person myPerson = db.Person.SingleOrDefault(user => user.Id == 1);
            myPerson.AddSkill(skill);

            db.AddSkill(skill);
            return RedirectToAction("About", "Home");
        }

        public ActionResult EditSkill(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Skill skill = db.GetSkill((int)id);

            if (skill == null) { return HttpNotFound(); }

            return View("~/Views/Skill/EditSkill.cshtml", skill);
        }

        [HttpPost]
        public ActionResult EditSkill(Skill skill)
        {
            db.EditSkill(skill);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult DeleteSkill(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Skill skill = db.GetSkill((int)id);

            if (skill == null) { return HttpNotFound(); }

            db.DeleteSkill(skill);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}