using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
    public class Repository : IRepository
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Message> Messages { get; set; } = new List<Message>();
        public User LoggedIn { get; set; }
    }
}