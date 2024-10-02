using Moq;
using PoolTicketManagementAPI.BusinessLogic;
using PoolTicketManagementAPI.DataAccess;
using PoolTicketManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.TestMethod
{
    internal class TicketAddTest
    {
        private Mock<IEntityRepository<Ticket>> ticketRepository;
        private TicketBL ticketBL;
        [SetUp]
        public void SetUp()
        {
            ticketRepository = new Mock<IEntityRepository<Ticket>>();
        }

        [Test]
        public void TestAddTicketMethod()
        {
            ticketBL = new TicketBL();
        }

    }
}
