using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoolTicketManagementAPI.IRepository;
using PoolTicketManagementAPI.Mappers;

namespace PoolTicketManagementAPI.Controllers
{
    [Route("/tickets/")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository _ticketRepo;

        public TicketController(ITicketRepository ticketRepository)
        {
            _ticketRepo = ticketRepository;
        }

        [HttpGet]
        public async Task<IActionResult> getAllTicket(){
            var tickets = (await _ticketRepo.GetAllTicket()
            ).Select(t => t.ToTicketResponse());
            
            var apiContent = new {
                result = true,
                message = "",
                tickets = tickets
            };

            return Ok(apiContent);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getTicketById(int id){
            var ticket = await _ticketRepo.GetTicketById(id);

            var apiContent = new {
                result = true,
                message = "",
                ticket = ticket
            };
            
            if (ticket == null){

                return StatusCode(404,"Not found this ticket");
            }

            return Ok(apiContent);
        }

    }
}