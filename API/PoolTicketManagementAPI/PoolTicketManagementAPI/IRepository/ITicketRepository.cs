using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoolTicketManagementAPI.Models;

namespace PoolTicketManagementAPI.IRepository
{
    public interface ITicketRepository
    {
        public Task<List<Ticket>> GetAllTicket();
        public Task<Ticket?> GetTicketById(int id);
    }
}