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
        public int MessageID { get; set; }
        public User Sender { get; set; }
        public User Recipient { get; set; }

        [StringLength(30, MinimumLength = 5)]
        [Required(ErrorMessage = "Please Enter the Subject.")]
        public string Subject { get; set; } = null;
        [StringLength(400, MinimumLength = 3)]
        [Required(ErrorMessage = "Please Enter your Message.")]
        public string Text { get; set; } = null;

        public DateTime SentDate { get; set; }

        // sender and recipient as int
        public int SenderInt { get; set; }
        public int RecipientInt { get; set; }
        #endregion



        #region Constructor
        public Message()
        {
            if (SentDate == null)
            {
                SentDate = DateTime.Now;
            }
        }
        #endregion



        #region Methods
        public void SetSenderFromInt(int index, IRepository repo)
        {
            Sender = repo.Users[index];
        }



        public void SetRecipientFromInt(int index, IRepository repo)
        {
            Recipient = repo.Users[index];
        }



        public int GetSenderAsInt(IRepository repo)
        {
            if (Sender == null)
            {
                return -1;
            }

            return repo.Users.IndexOf(Sender);
        }



        public int GetRecipientAsInt(IRepository repo)
        {
            if (Recipient == null)
            {
                return -1;
            }

            return repo.Users.IndexOf(Recipient);
        }
        #endregion
    }
}
