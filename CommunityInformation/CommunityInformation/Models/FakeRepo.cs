using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
    public class FakeRepo : IRepository
    {
        public List<User> Users { get; set; } = new List<User>() { };
        public List<Message> Messages { get; set; } = new List<Message>();
        public User LoggedIn { get; set; }



        public FakeRepo()
        {
            User user1 = new User() { Name = "Kolton" };
            User user2 = new User() { Name = "Bobby" };
            User user3 = new User() { Name = "Hank" };
            Users.AddRange(new User[] { user1, user2, user3 });
            Message message1 = new Message() { Subject = "This site sucks", Text = "Not kidding, RIP.", Recipient = user2, Sender = user1 };
            Message message2 = new Message() { Subject = "RE: This site sucks", Text = "bruh, swag yeah", Recipient = user1, Sender = user2 };
            Message message4 = new Message() { Subject = "u r loser", Text = "Git gud, Bobby.", Recipient = user2, Sender = user3 };
            Message message3 = new Message() { Subject = "Wait till Bobby sees this!", Text = "Dang it, Bobby.", Recipient = user1, Sender = user3 };
            Messages.AddRange(new Message[] { message1, message2, message3, message4 });
            // log in as Bobby
            LoggedIn = user2;
        }
    }
}
