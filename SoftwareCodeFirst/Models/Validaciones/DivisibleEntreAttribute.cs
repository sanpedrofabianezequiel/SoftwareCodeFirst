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
        public DivisibleEntreAttribute(int dividendo) : base("Number {0} is't valid")
        {
            this._dividendo=dividendo;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}