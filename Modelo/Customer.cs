
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Customer
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1-40}$",
            ErrorMessage = "Character ar not allowed.")]

        public string? FirstName { get; set; }
    }
}
