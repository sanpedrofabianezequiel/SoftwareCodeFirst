using SoftwareCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SoftwareCodeFirst.Service
{
    public class BlogPostsRepository
    {
        //Creamos un DbContext que se va a encargar las operaciones de BD

        //Creamos un metodo que devuelva una lista de BlogPost con el DBContext
        public List<BlogPost> ObtenerTodos()
        {
            //Instanciamos el NombreDbContext dentro de un USING
            //lo almacenamos en un VAR
            //Para asegurarnos que se liberen esos recursos
            using (var db = new BlogContext())
            {
                //En esta Instancia le realizamos una Query a la 
                //BD y la query
                //ToList => devuelve todo
                //.INCLUDE permite traer los items FK especificados
                //Crear Using de Entity para usar Lambda en INCLUDE(using System.Data.Entity;)
                //EJ: x=> x.Comentarios
                return db.BlogPosts.Include(x=>x.Comentarios).ToList();
            }
        }

        internal void Crear(BlogPost collection)
        {
            //Usamos EntityFrameWork para guardar ese dato con un USING
            using (var db= new BlogContext())
            {
                //Debemos usar el Metodo add de entity y mandarle el modelo
                //y persistir los cambios
                db.BlogPosts.Add(collection);
                db.SaveChanges();
            }
        }
    }
}