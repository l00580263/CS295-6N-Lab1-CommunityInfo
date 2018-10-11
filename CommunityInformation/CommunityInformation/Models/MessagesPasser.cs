using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
    public class MessagesPasser
    {
        #region Fields
        #endregion

        #region Properties
        // for messages httpget
        public List<Message> Messages { get; set; }
        public List<User> Users { get; set; }
        public User LoggedUser { get; set; }
        // for messages httppost
        public string Subject { get; set; }
        public int? Recipient { get; set; }
        public string Text { get; set; }

        public bool Sending { get; set; }
        #endregion
    }
}
