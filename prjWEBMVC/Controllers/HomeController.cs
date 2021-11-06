using prjWEBMVC.Models;
using projectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjWEBMVC.Controllers
{
    public class HomeController : Controller
    {

        Writers w = new Writers();

        public ActionResult Index()
        {
            var list = w.GetList();
            return View(list);
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult Create(Write write)
        {
            ViewBag.Message = "Your application description page.";
            if (ModelState.IsValid) {

                if (write != null)
                {
                    w.AddWrite(write);
                    return RedirectToAction("Index");
                }
                else {
                    ModelState.AddModelError("", "Write Not Null!");
                }
            }
             ModelState.AddModelError("","Error validation!");
            return View(write);
        }


        public ActionResult Edit(int id)
        {
            var write = w.GetWrite(id);
            ViewBag.Message = "Your contact page.";
            if (write !=null) {
                return View(write);
            }
            ModelState.AddModelError(null,"Not Object!");
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Write write)
        {
            if (write!=null) {
                w.Update(write);
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Your contact page.";
            ModelState.AddModelError(null, "Not Object For Edit!");
            return View();
        }

        public ActionResult Delete(int id) {
            var write = w.GetWrite(id);
            return View(write);
        }
        [HttpPost]
        public ActionResult Delete(Write write)
        {
            var write1 = w.GetWrite(write.Id);
            if (write1 != null) {
                w.RemoveWrite(write1);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(null, "Not Delete!");
            return View(write1);
        }

        public ActionResult Details(int id) {
            return View(w.GetWrite(id));
        }
    }
}