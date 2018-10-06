using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
    public class User
    {
        #region Fields
        List<Message> messages = new List<Message>();
        #endregion


        #region Properties
        public string Name { get; set; }
        #endregion
    }
}
