using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace ParkingSystem.WebUI.Models
{
    public partial class ParkingLotSystemContext : DbContext
    {
        public ParkingLotSystemContext()
        {
        }
        public IConfiguration _configuration;
        public ParkingLotSystemContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ParkingLotSystemContext(DbContextOptions<ParkingLotSystemContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Ticket> Ticket { get; set; }

        public virtual DbSet<TicketPayment> TicketPayment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration["AppConnectionString"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
