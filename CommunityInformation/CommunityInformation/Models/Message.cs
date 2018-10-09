using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommunityInformation.Models
{
    public class Message
    {



        #region properties
        //[Required(ErrorMessage = "Please Enter your Name.")]
        public User Sender { get; set; }
        //[Required(ErrorMessage = "Please Enter the Recipient.")]
        public User Recipient { get; set; }
        [Required(ErrorMessage = "Please Enter the Subject.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please Enter your Message.")]
        public string Text { get; set; }
        #endregion
    }
}
