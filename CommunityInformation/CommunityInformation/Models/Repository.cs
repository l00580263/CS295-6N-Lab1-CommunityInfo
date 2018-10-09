using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
    public class Repository
    {
        // tmp properties
        public static bool Fresh { get; set; } = true;
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Message> Messages { get; set; } = new List<Message>();
        public static User LoggedIn { get; set; }
    }
}