using GCCafe.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace GCCafe.Data
{
    public class GCCafeInitializer : DropCreateDatabaseAlways<GCCafeContext>
    {
        protected override void Seed(GCCafeContext context)
        {
            var item = new Item()
            {
                Id = 1,
                Name = "Black Coffee",
                Quantity = 1,
                Price = 1.99
            };
            context.Items.Add(item);
            context.SaveChanges();
            var user = new User()
            {
                Id = 1,
                FirstName = "Michael",
                LastName = "Cacciano",
                Email = "mcacciano@gmail.com",
                PhoneNumber = "555-555-5555",
                Password = "password1"
            };
            context.Users.Add(user);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
