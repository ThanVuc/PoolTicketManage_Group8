using PoolTicketManagementAPI.DataAccess;
using PoolTicketManagementAPI.Models;

namespace PoolTicketManagementAPI.BusinessLogic
{
    public class TicketBL
    {
        private IEntityRepository<Ticket> _entityRepo;

        public TicketBL()
        {
        }

        public TicketBL(IEntityRepository<Ticket> entityRepository)
        {
            _entityRepo = entityRepository;
        }

        public bool InsertTicket(Ticket ticket)
        {
            var isAdded = false;
            try
            {
                _entityRepo.insert(ticket);
                isAdded = true;
            } catch (Exception ex)
            {
                isAdded = false;
            }
            return isAdded;
        }
           
    }
}
