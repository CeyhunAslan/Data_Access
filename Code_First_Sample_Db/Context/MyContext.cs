using Code_First_Sample_Db.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Sample_Db.Context
{
    public class MyContext:DbContext
    {
        public MyContext()
        {
            //Connection String Constructor method içerisinde yazılır.

            //Windows Authenticaiton
            Database.Connection.ConnectionString = @"Server=SHADOWBLOOD\ETA;Database=CodeFirst;Integrated Security=true;";
        }
        //Tools açıp PM> "enable-migrations" yazıyorum Connection String contractor içine yazılır ki initialize (run time , çalışma anında)database'e bağlansın


        //Modelimi DBContext ile Db'ye yollarken classlarımı DbSet ile Db'ye tablo olarak yolluyorum
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<MovieToGenre> MovieToGenres { get; set; }
        public DbSet<MovieToActor> MovieToActors { get; set; }

        //OnModelCreating Void Methopduna Configrasyonlarımı yazıyorum
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //one-to-many relationship between Dicrector and Movies
            //Director ve Movie tablom arasındaki bir'e çok ilişkim
            modelBuilder.Entity<Director>().HasMany(d => d.Movies)
                                           .WithRequired(m => m.Director)
                                           .HasForeignKey(m => m.DirectorId);




            //many-to-many relationship between Genre and Movies(with dummy table)
            //Genre ve Movie tablom arasında çoka çok ilişkim

            modelBuilder.Entity<MovieToGenre>().HasRequired(mg => mg.Movie)
                .WithMany(mg => mg.MovieToGenres)
                .HasForeignKey(mg => mg.MoiveId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovieToGenre>().HasRequired(mg => mg.Genre)
                .WithMany(mg => mg.MovieToGenres)
                .HasForeignKey(mg => mg.GenreId)
                .WillCascadeOnDelete(false);

            
            
            modelBuilder.Entity<MovieToActor>().HasRequired(ma => ma.Actor)
               .WithMany(ma => ma.MovieToActors)
               .HasForeignKey(ma => ma.ActorId)
               .WillCascadeOnDelete(false);


            modelBuilder.Entity<MovieToActor>().HasRequired(ma => ma.Movie)
              .WithMany(ma => ma.MovieToActors)
              .HasForeignKey(ma => ma.MovieId)
              .WillCascadeOnDelete(false);
        }                                
    }
}
