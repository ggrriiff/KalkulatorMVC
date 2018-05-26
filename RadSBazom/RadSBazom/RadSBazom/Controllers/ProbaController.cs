using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RadSBazom.Models;

namespace RadSBazom.Controllers
{
    public class ProbaController : Controller
    {
        private shareAndConnectEntities db = new shareAndConnectEntities();
        // GET: Proba
        public ActionResult Index()
        {
            var model = db.Skills.Where(sk => sk.SkillName.Contains("C")).ToList();
            return View((object)model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kreiraj(Skill skill)
        {
            db.Skills.Add(skill);
            int promjene = db.SaveChanges();

            return Redirect("../Proba/Index");
        }

        //[HttpPost] - nije post metoda jer nije pozvana iz forme sa Submit buttonom!
        public ActionResult Delete(int id)
        {
            Skill skill = db.Skills.FirstOrDefault(sk => sk.Id == id);
            db.Skills.Remove(skill);
            db.SaveChanges();
            return Redirect("../Index");
        }
    }
}