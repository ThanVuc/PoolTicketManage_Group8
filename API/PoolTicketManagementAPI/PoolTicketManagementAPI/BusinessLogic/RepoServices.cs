using PoolTicketManagementAPI.IRepository;
using PoolTicketManagementAPI.Models;

namespace PoolTicketManagementAPI.BusinessLogic
{
    public class RepoServices
    {
        ITicketRepository _ticketRepo;

        public RepoServices(ITicketRepository ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }

        public async Task<List<Ticket>> GetAllTicket()
        {
            var tickets = await _ticketRepo.GetAllTicket();
            // Filter

            tickets = tickets.Where(t => t.TicketId != 2).ToList();

            return tickets;
        }

        public Task<Ticket?> GetTicketById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
