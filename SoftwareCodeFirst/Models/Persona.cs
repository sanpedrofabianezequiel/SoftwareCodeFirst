using SoftwareCodeFirst.Models.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareCodeFirst.Models
{
    public class Persona
    {
        [Key]
        public  int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }
        [StringLength(6,MinimumLength =5,ErrorMessage = "El campo {0} es requerido")]
        public string CodigoPostal { get; set; }
        [Range(18,60,ErrorMessage = "La edad tiene que ser mayor a {1}")]
        public int Edad { get; set; }
        [StringLength(200)]
        [Required]
        public string Email { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Email",ErrorMessage ="El Email no coincide")]
        public string ConfirmarEmail { get; set; }
        [CreditCard(ErrorMessage = "Tarjeta Invalida")]
        public string TarjetaDeCredito { get; set; }

        [Remote("AccionPropia", "Persona",ErrorMessage ="El numero no es divisible por 2")]
        [DivisibleEntre(2)]
        public int NumeroDivisibleEntre2 { get; set; }
    }
}