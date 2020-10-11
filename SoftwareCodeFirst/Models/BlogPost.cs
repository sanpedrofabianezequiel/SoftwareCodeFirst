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
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(300,MinimumLength =100,ErrorMessage = "Longituda del {0} debe ser como minimo {2} y maximo {1}")]
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