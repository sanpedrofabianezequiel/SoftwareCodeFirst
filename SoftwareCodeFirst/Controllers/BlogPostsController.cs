using SoftwareCodeFirst.Models;
using SoftwareCodeFirst.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareCodeFirst.Controllers
{
    public class BlogPostsController : Controller
    {
        //Utilizamos un Service que le pega a la BD con DbContext
        private BlogPostsRepository _repository;

        //Constructor
        public BlogPostsController()
        {
            _repository = new BlogPostsRepository();
        }



        // GET: BlogPosts
        public ActionResult Index()
        {

           var listaBlogs = _repository.ObtenerTodos();
            //Le indicamos que del primer BlogPost de la lista,traiga el
            //primer comentario
            var comentario = listaBlogs[0].Comentarios[0];

            return View(listaBlogs);
        }

        // GET: BlogPosts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPosts/Create
        [HttpPost]
        public ActionResult Create(BlogPost collection)
        {
            try
            {
                // TODO: Add insert logic here
                //Verificamos el estado de el create
                if (ModelState.IsValid)
                {
                    _repository.Crear(collection);
                    return RedirectToAction("Index");
                }

               
            }
            catch(Exception ex)
            {
                //Error
            }
            return View(collection);
        }

        // GET: BlogPosts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogPosts/Edit/5
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

        // GET: BlogPosts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogPosts/Delete/5
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
