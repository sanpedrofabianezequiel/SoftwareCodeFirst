using SoftwareCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareCodeFirst.Service
{
    public class PersonasRepository
    {
        //Connection to BD Funtions
        public List<Persona> obtenerTodos()
        {
            using (var db= new BlogContext())
            {
                return db.Personas.ToList();
            }
        }

        public void Crear(Persona collection)
        {
            //throw new NotImplementedException();
            using (var db = new BlogContext())
            {
                db.Personas.Add(collection);
                db.SaveChanges();
            }
            
        }
    }
}