using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Tictactoe.Entities

{

    public class GameDBcontext : DbContext
    {
       
        private string connectionString = "Server=tictactoe-db.celeubkghsq8.eu-north-1.rds.amazonaws.com;Database=tictactoe-db;User ID=admin;Password=;";



        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(r => r.Id)
                .IsRequired()
                .HasMaxLength(25);


        }


        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }




}