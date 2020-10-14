using Recursos;
using SoftwareCodeFirst.Models.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareCodeFirst.Models
{
    public class Persona:IValidatableObject
    {
        [Key]
        public  int Id { get; set; }
        // [Required(ErrorMessage = "El campo {0} es requerido")]
        [Required(ErrorMessageResourceType =typeof(Recurso),ErrorMessageResourceName = "Mensaje_Error_Required")]
        //Indicamos de donde sacamos el recurso,segundo parametro es el campo definido en
        //el archivo RESX
        [Display(ResourceType = typeof(Recurso), Name = "Persona_Nombre_Texto_Mostrar")]

        public string Nombre { get; set; }

        [Display(Name ="Codigo Postal")]
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
        [Display(Name ="Tarjeta de Credito")]
        public string TarjetaDeCredito { get; set; }

        [Remote("AccionPropia", "Persona",ErrorMessage ="El numero no es divisible por 2")]//Validacion en JQUERY
        [DivisibleEntre(2)] //Validacion en SERVIDOR con clase Propia
        [Display(Name = "Numero Divisible entre 2")]
        public int NumeroDivisibleEntre2 { get; set; }





        //Metodos IValidationObject
        public decimal Salario { get; set; }
        public decimal MontoSolicitado { get; set; }
        #region Metodos que se implementa cuando implemento la Interfaz
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Creamos un NUEVA =>NEW  listado de validaciones/errores
            var resultado = new List<ValidationResult>();
            if (Salario *4 < MontoSolicitado)
            {
                //Agregamos un nuevo objeto a la lista, del tipo ValidationResult
                resultado.Add(new ValidationResult("El monto solicitud no debe exceder 4 veces el Salario",
                        new string[] {"MontoSolicitado"}
                        ));
            }

            //Finalmente retornamos la lista de Errores
            //Si la lista esta vacia, ASP=>Validation = OK
            return resultado;
        }
        #endregion
    }
}