using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoolTicketManagementAPI.DTOs;
using PoolTicketManagementAPI.Models;

namespace PoolTicketManagementAPI.Mappers
{
    public static class TicketMapper
    {
        public static TicketResponse ToTicketResponse(this Ticket ticketModel){
            return new TicketResponse(){
                TicketId = ticketModel.TicketId,
                TicketName = ticketModel.TicketName,
                Description = ticketModel.Description,
                Price = ticketModel.Price,
                Url = ticketModel.Url,
                ValidFrom = ticketModel.ValidFrom,
                ValidUntil = ticketModel.ValidUntil
            };
        }
    }
}