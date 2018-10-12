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
        public User Sender { get; set; }
        public User Recipient { get; set; }

        [Required(ErrorMessage = "Please Enter the Subject.")]
        public string Subject { get; set; } = null;
        [Required(ErrorMessage = "Please Enter your Message.")]
        public string Text { get; set; } = null;

        public DateTime SentDate { get; }
        #endregion



        #region Constructor
        public Message()
        {
            SentDate = DateTime.Now;
        }
        #endregion



        #region Methods
        public void SetSenderFromInt(int index)
        {
            Sender = Repository.Users[index];
        }



        public void SetRecipientFromInt(int index)
        {
            Recipient = Repository.Users[index];
        }



        public int GetSenderAsInt()
        {
            if (Sender == null)
            {
                return -1;
            }

            return Repository.Users.IndexOf(Sender);
        }



        public int GetRecipientAsInt()
        {
            if (Recipient == null)
            {
                return -1;
            }

            return Repository.Users.IndexOf(Recipient);
        }
        #endregion
    }
}
