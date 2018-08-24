using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GCCafe.Domain.Models;
using GCCafe.Data.Maps;

namespace GCCafe.Data
{
    public class GCCafeContext : DbContext
    {

        public GCCafeContext() : base("GCCafe")
        {
            Database.SetInitializer(new GCCafeInitializer);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ItemMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
