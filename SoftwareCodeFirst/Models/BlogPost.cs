using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftwareCodeFirst.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }
        [Required]
        public string Contenido { get; set; }
        [StringLength(100)]
        public string Autor { get; set; }
        public DateTime Publicacion { get; set; }
        //Aca cada BlogPost le corresponde un comentario
        public List<Comentarios> Comentarios { get; set; }
    }
}