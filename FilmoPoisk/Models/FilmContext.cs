using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Filmopoisk.Models
{
    public class FilmContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }

        public FilmContext() : base("DefaultConnection") { }


        // Создание промежуточной таблицы FilmActor для обеспечения связи многие ко многим

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasMany(c => c.Actors)
                .WithMany(s => s.Films)
                .Map(t => t.MapLeftKey("FilmId")
                .MapRightKey("ActorId")
                .ToTable("FilmActor"));
        }
    }
}