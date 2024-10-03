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

            modelBuilder.Entity<User>()
            .HasMany(u => u.Pools)
            .WithOne(p => p.PoolOwner)
            .OnDelete(DeleteBehavior.NoAction);

            List<User> users = new List<User>(){
                new User(){
                    UserId = 1,
                    UserName = "User 1",
                    Email = "User1@gmail.com",
                    Password = "123",
                    CreatedDate = "22/12/2004",
                    PhoneNumber = "0000005"
                },
                new User(){
                    UserId = 2,
                    UserName = "User 2",
                    Email = "User2@gmail.com",
                    Password = "123",
                    CreatedDate = "10/10/2004",
                    PhoneNumber = "0002305"
                }
            };

            List<Pool> pools = new List<Pool>{
                new Pool(){
                    PoolId = 1,
                    PoolName = "Children Pool",
                    Capacity = 75000,
                    Location = "Dien Bien Phu",
                    Url = "http://localhost:5051/images/ho-boi-cho-tre-em.jpeg",
                    PoolOwnerId = 1,
                    Description = "The pool is for children with the clear and cold water",
                    OpenTime = "7:30",
                    CloseTime = "19:00"
                },
                new Pool(){
                    PoolId = 2,
                    PoolName = "Family Pool",
                    Capacity = 75000,
                    Location = "Ha Huy Tap",
                    Url = "http://localhost:5051/images/hoboigiadinh.jpg",
                    PoolOwnerId = 2,
                    Description = "The pool is for Family with the clear and cold water",
                    OpenTime = "7:30",
                    CloseTime = "19:00"
                },
                new Pool(){
                    PoolId = 3,
                    PoolName = "WaterFall Pool",
                    Capacity = 75000,
                    Location = "Hoa Cuong 9",
                    Url = "http://localhost:5051/images/thac-nuoc-trang-tri-ho-boi-11.jpg",
                    PoolOwnerId = 1,
                    Description = "The Waterfall pool is the natural pool, it is very clear and the atmosphere is so fresh",
                    OpenTime = "7:30",
                    CloseTime = "19:00"
                },
                new Pool(){
                    PoolId = 4,
                    PoolName = "Artificial Wave Pool",
                    Capacity = 75000,
                    Location = "Ha Huy Tap",
                    Url = "http://localhost:5051/images/songnhantao.jpg",
                    PoolOwnerId = 2,
                    Description = "The pool has the artifical wave as the beach but the waves is so lighlier than the beach",
                    OpenTime = "7:30",
                    CloseTime = "19:00"
                }
            };


            // add sample data
            List<Ticket> tickets = new List<Ticket>{
                new Ticket(){
                    TicketId = 1,
                    PoolId = 1,
                    Description = "Trãi nghiệm hồ bơi trong lành và mát mẽ",
                    TicketName = "Children Pool Ticket",
                    Price = 99999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(8),
                    Url = "http://localhost:5051/images/ho-boi-cho-tre-em.jpeg"
                },
                new Ticket(){
                    TicketId = 2,
                    PoolId = 2,
                    TicketName = "Family Pool",
                    Description = "Trãi nghiệm hồ bơi trong lành và mát mẽ",
                    Price = 99999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(8),
                    Url = "http://localhost:5051/images/hoboigiadinh.jpg"
                },
                new Ticket(){
                    TicketId = 3,
                    PoolId = 3,
                    TicketName = "Waterfall Pool Ticket",
                    Description = "Trãi nghiệm hồ bơi trong lành và mát mẽ",
                    Price = 99999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(8),
                    Url = "http://localhost:5051/images/thac-nuoc-trang-tri-ho-boi-11.jpg"
                },
                new Ticket(){
                    TicketId = 4,
                    PoolId = 4,
                    TicketName = "Artifical Wave Pool Ticket",
                    Description = "Trãi nghiệm hồ bơi trong lành và mát mẽ",
                    Price = 99999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(8),
                    Url = "http://localhost:5051/images/songnhantao.jpg" 
                }
            };

            modelBuilder.Entity<User>()
            .HasData(users);

            modelBuilder.Entity<Pool>()
            .HasData(pools);

            modelBuilder.Entity<Ticket>()
            .HasData(tickets);
        }

        public DbSet<Pool> Pools {get; set;}
        public DbSet<Event> Events {get; set;}
        public DbSet<User> Users {get; set;}
        public virtual DbSet<Ticket> Tickets {get; set;}

        public DbSet<Question> Questions {get; set;}
        public DbSet<EventOfPool> EventOfPools {get; set;}
        public DbSet<BusTicket> BusTickets {get; set;}
        public DbSet<Bill> Bills {get; set;}
        public DbSet<UserRole> UserRoles {get; set;}
        public DbSet<CartItem> CartItems {get; set;}
        public DbSet<Role> Roles {get; set;}
    }
}