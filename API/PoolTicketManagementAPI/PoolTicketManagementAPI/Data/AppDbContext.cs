using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PoolTicketManagementAPI.Models;

namespace PoolTicketManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CartItem>(entity => {
                entity.HasKey(c => new {c.TicketId, c.UserId});
            });

            
            modelBuilder.Entity<UserRole>(entity => {
                entity.HasKey(u => new {u.RoleId, u.UserId});
            });

            
            modelBuilder.Entity<EventOfPool>(entity => {
                entity.HasKey(c => new {c.EventId, c.PoolId});
            });
        }

        public DbSet<Pool> Pools {get; set;}
        public DbSet<Event> Events {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<Ticket> Tickets {get; set;}
        public DbSet<Question> Questions {get; set;}
        public DbSet<EventOfPool> EventOfPools {get; set;}
        public DbSet<BusTicket> BusTickets {get; set;}
        public DbSet<Bill> Bills {get; set;}
        public DbSet<UserRole> UserRoles {get; set;}
        public DbSet<CartItem> CartItems {get; set;}
        public DbSet<Role> Roles {get; set;}
    }
}