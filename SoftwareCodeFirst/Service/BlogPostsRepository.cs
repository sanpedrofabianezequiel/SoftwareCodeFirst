using SoftwareCodeFirst.Models;
using System;
using System.Collections.Generic;
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
            //Instanciamos el DbContext dentro de un USING
            //Para asegurarnos que se liberen esos recursos

        }


    }
}