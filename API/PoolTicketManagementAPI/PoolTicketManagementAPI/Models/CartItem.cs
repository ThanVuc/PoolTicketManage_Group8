using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PoolTicketManagementAPI.Models
{
    public class CartItem
    {
        public int TicketId { get; set; }
        public int UserId {get; set;}
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18)")]
        public decimal Price {get; set;}

        [ForeignKey("TicketId")]
        public Ticket? Ticket { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}