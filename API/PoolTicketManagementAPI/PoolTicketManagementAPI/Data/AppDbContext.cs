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

            
            List<Pool> pools = new List<Pool>{
                new Pool(){
                    PoolId = 1,
                    PoolName = "Children Pool",
                    Capacity = 75000,
                    Location = "Dien Bien Phu",
                    Url = "/images/ho-boi-cho-tre-em.jpeg"
                },
                new Pool(){
                    PoolId = 2,
                    PoolName = "Family Pool",
                    Capacity = 75000,
                    Location = "Ha Huy Tap",
                    Url = "/images/hoboigiadinh.jpg"
                },
                new Pool(){
                    PoolId = 3,
                    PoolName = "WaterFall Pool",
                    Capacity = 75000,
                    Location = "Hoa Cuong 9",
                    Url = "/images/thac-nuoc-trang-tri-ho-boi-11.jpg"
                },
                new Pool(){
                    PoolId = 4,
                    PoolName = "Artificial Wave Pool",
                    Capacity = 75000,
                    Location = "Ha Huy Tap",
                    Url = "/images/songnhantao.jpg"
                }
            };


            // add sample data
            List<Ticket> tickets = new List<Ticket>{
                new Ticket(){
                    TicketId = 1,
                    PoolId = 1,
                    TicketName = "Children Pool Ticket",
                    Price = 99999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(8),
                    Url = "/images/ho-boi-cho-tre-em.jpeg"
                },
                new Ticket(){
                    TicketId = 2,
                    PoolId = 2,
                    TicketName = "Family Pool",
                    Price = 99999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(8),
                    Url = "/images/hoboigiadinh.jpg"
                },
                new Ticket(){
                    TicketId = 3,
                    PoolId = 3,
                    TicketName = "Waterfall Pool Ticket",
                    Price = 99999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(8),
                    Url = "/images/thac-nuoc-trang-tri-ho-boi-11.jpg"
                },
                new Ticket(){
                    TicketId = 4,
                    PoolId = 4,
                    TicketName = "Artifical Wave Pool Ticket",
                    Price = 99999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(8),
                    Url = "/images/songnhantao.jpg" 
                }
            };

            modelBuilder.Entity<Pool>()
            .HasData(pools);

            modelBuilder.Entity<Ticket>()
            .HasData(tickets);
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