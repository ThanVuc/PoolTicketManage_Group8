using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PoolTicketManagementAPI.Data;
using PoolTicketManagementAPI.IRepository;
using PoolTicketManagementAPI.Models;

namespace PoolTicketManagementAPI.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _context;

        public TicketRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<List<Ticket>> GetAllTicket()
        {
            var tickets = await _context.Tickets.ToListAsync();

            return tickets;

        }

        public async Task<Ticket?> GetTicketById(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            
            if (ticket == null){
                return null;
            }

            return ticket;
        }
    }
}