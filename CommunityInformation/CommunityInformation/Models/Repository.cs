using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
    public class Repository : IRepository
    {
        public User LoggedIn { get; set; }


        ApplicationDbContext context;

        public List<Message> Messages
        {
            get
            {
                return context.Messages.ToList();
            }
        }

        public List<User> Users
        {
            get
            {
                return context.Users.ToList();
            }
        }



        public Repository(ApplicationDbContext c)
        {
            context = c;
            // set logged in user
            LoggedIn = context.Users.ToList()[1];
        }



        public void AddMessage(Message m)
        {
            if (m.Text == null)
            {
                m.Text = "";
            }

            if (m.Subject == null)
            {
                m.Subject = "";
            }

            context.Messages.Add(m);
            context.SaveChanges();
        }
    }
}