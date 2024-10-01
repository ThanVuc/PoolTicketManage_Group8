using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.DTOs
{
    public class TicketResponse
    {
        public int TicketId { get; set; }
        public string TicketName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime ValidFrom { get; set;}
        public DateTime ValidUntil {get; set;}
        public string Url {get; set;} = string.Empty;
    }
}