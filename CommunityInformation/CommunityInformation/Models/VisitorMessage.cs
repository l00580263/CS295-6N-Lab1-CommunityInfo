using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommunityInformation.Models
{
    public class VisitorMessage
    {



        #region properties
        [Required(ErrorMessage = "Please Enter your Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter your Email.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Enter Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter your Message.")]
        public string Message { get; set; }
        #endregion
    }
}
