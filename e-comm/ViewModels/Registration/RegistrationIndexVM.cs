using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.ViewModels.Registration
{
    public class RegistrationIndexVM
    {

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Username { get; set; }

        [Required]
        [StringLength(320)]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }
    }
}
