using System;
using assignment_4.Models;

namespace assignment_4.Data
{
    public class ApplicationDbInitializer
    {
        public static void Initialize(ApplicationDbContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var bloguser1 = new BlogUser
            {
                Nickname = "AliG",
                Title = "Test tittel",
                Summary = "Dette er et sammendrag",
                Content = "Dette er innholdet",
                Time = new DateTime(2021, 10, 13)
            };

            db.BlogUsers.Add(bloguser1);
            db.SaveChanges();
        }
    }
}