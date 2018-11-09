using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
    public class InitializeDb
    {



        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            User user1 = new User() { Name = "Kolton" };
            User user2 = new User() { Name = "Bobby" };
            User user3 = new User() { Name = "Hank" };
            Message message1 = new Message() { Subject = "This site sucks", Text = "Not kidding, RIP.", Recipient = user2, Sender = user1 };
            Message message2 = new Message() { Subject = "RE: This site sucks", Text = "bruh, swag yeah", Recipient = user1, Sender = user2 };
            Message message4 = new Message() { Subject = "u r loser", Text = "Git gud, Bobby.", Recipient = user2, Sender = user3 };
            Message message3 = new Message() { Subject = "Wait till Bobby sees this!", Text = "Dang it, Bobby.", Recipient = user1, Sender = user3 };
            Message message5 = new Message() { Subject = "added", Text = "added more", Recipient = user2, Sender = user3 };
            Message message6 = new Message() { Subject = "test", Text = "test more", Recipient = user1, Sender = user3 };

            context.Database.Migrate();

            if (!context.Messages.Any())
            {
                // add messages
                context.Messages.AddRange(message1, message2, message3, message4, message5, message6);
            }

            if (!context.Users.Any())
            {
                // add users
                context.Users.AddRange(user1, user2, user3);
            }

            context.SaveChanges();
        }
    }
}
