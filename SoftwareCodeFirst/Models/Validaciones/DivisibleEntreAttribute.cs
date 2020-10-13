using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftwareCodeFirst.Models.Validaciones
{
    public class DivisibleEntreAttribute:ValidationAttribute
    {
        private int _dividendo;
        //1 Creamos un constructor con la clase padre y enviamos el mensaje
        //2 verifamos que no sea null y casteamos en el IF
        //3 enviamos en el var miResul= FormatErroMessage(Validationcontexto.displayname)
        //4 retornamos una NUEVA =>NEW instancia de VALIDATIONRESULT(mensaje)
        //5 llamamos a la clase como una anotacion en mi MODELO
        public DivisibleEntreAttribute(int dividendo) : base("Number {0} is't valid")
        {
            this._dividendo=dividendo;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                if ((int) value % _dividendo !=0)   //Si es distinto osea no es PAR, ejecutamos el error
                {
                    var mensaje = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(mensaje);
                }
            }

            return ValidationResult.Success;
        }
    }
}