using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuboNetBeta.Models
{
    public class Usuario
    {


        public int Id { get; set; }
        [Required]
        public string Nombre  { get; set; }
        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9_.+]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
                            ErrorMessage = ("Invalid Email Format"))]
        public string  Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Confirmation { get; set; }
    }
}
