using LibraryProject.Infrastructure.EntityTypeConfigruation.Concrete;
using LibraryProject.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = @"SHADOWBLOOD\ETA;Database=LibraryProjectDB;Integrated Security=true;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookToAuthor> BookToAuthors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new BookToAuthorMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
