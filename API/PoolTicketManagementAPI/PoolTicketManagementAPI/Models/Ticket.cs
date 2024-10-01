using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string TicketName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18)")]
        public decimal Price { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil {get; set;}
        public int PoolId {get; set;}
        [ForeignKey("PoolId")]
        public Pool? Pool {get; set;}
    }
}