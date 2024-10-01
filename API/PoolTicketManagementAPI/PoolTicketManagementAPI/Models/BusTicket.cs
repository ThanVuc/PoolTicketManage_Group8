using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class BusTicket
    {
        public int BusTicketId { get; set; }
        public string? BusTicketName {get; set;}
        public int SeatNumber { get; set; }
        public DateTime DepartureTime {get; set;}
        public int PoolId {get; set;}
        [ForeignKey("PoolId")]
        public Pool? Pool {get; set;}
    }
}