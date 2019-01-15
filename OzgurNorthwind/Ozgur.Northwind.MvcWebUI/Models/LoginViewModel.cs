using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ozgur.Northwind.MvcWebUI.Models
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(dataType:DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
