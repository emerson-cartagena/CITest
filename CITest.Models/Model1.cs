using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CITest.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=GameModel")
        {
        }

        public virtual DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
