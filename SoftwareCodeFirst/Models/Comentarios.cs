using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoftwareCodeFirst.Models
{
    public class Comentarios
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string Autor { get; set; }
        //Vinculacion o relacion con el BlogPost
        //Acada comentario le corresponde un BlogPost
        public int BlogPostId { get; set; }
        //Entity=> propiedad NAVIGACIONAL
        [ForeignKey("BlogPostId")]
        public BlogPost BlogPost { get; set; }
    }

}