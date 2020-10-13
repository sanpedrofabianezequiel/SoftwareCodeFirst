using SoftwareCodeFirst.Models;
using SoftwareCodeFirst.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareCodeFirst.Controllers
{
    public class PersonaController : Controller
    {
        private PersonasRepository _repository;

        public  PersonaController() //Constructor
        {

            this._repository = new PersonasRepository();
        }
        // GET: Persona
        public ActionResult Index()
        {
            var resul= _repository.obtenerTodos();
            return View(resul);
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public JsonResult AccionPropia(int NumeroDivisibleEntre2)
        {
            var validacion = NumeroDivisibleEntre2 % 2 == 0;
            return Json(validacion, JsonRequestBehavior.AllowGet);
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(Persona collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.Crear(collection);
                    return RedirectToAction("Index");
                }   

                
            }
            catch
            {//Si da error enviamos la misma data a la misma view
                
            }
            return View(collection);
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona/Edit/5
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

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona/Delete/5
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
    }
}
