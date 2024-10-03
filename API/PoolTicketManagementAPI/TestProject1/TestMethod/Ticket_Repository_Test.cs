using Microsoft.EntityFrameworkCore;
using Moq;
using PoolTicketManagementAPI.BusinessLogic;
using PoolTicketManagementAPI.Data;
using PoolTicketManagementAPI.IRepository;
using PoolTicketManagementAPI.Models;
using PoolTicketManagementAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.TestMethod
{
    internal class Ticket_Repository_Test
    {
        Mock<ITicketRepository> _ticketRepoMock;
        RepoServices repoServices;
        List<Ticket> tickets;


        [SetUp]
        public void Setup()
        {
            _ticketRepoMock = new Mock<ITicketRepository>();
            tickets = new List<Ticket>()
            {
                new Ticket()
                {
                    TicketId = 1,
                    PoolId = 1,
                    TicketName = "Ticket1",
                    Price = 9999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(7),
                    Description = "Hey",
                    Url = "/abcxyz/img"
                },
                new Ticket()
                {
                    TicketId = 2,
                    PoolId = 1,
                    TicketName = "Ticket2",
                    Price = 9999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(7),
                    Description = "Hey",
                    Url = "/abcxyz/img"
                },
                new Ticket()
                {
                    TicketId = 3,
                    PoolId = 1,
                    TicketName = "Ticket3",
                    Price = 9999,
                    ValidFrom = DateTime.Now,
                    ValidUntil = DateTime.Now.AddDays(7),
                    Description = "Hey",
                    Url = "/abcxyz/img"
                },
            };

            _ticketRepoMock.Setup(t => t.GetAllTicket()).ReturnsAsync(tickets);
            repoServices = new RepoServices(_ticketRepoMock.Object);

        }

        [Test]
        public async Task Test_TicketRepository_Async()
        {
            var result = await repoServices.GetAllTicket();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);

        }
    }
}
