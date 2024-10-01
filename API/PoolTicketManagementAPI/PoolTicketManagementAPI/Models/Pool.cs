using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class Pool
    {
        public int PoolId { get; set; }
        public string PoolName {get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string Description {get; set;} = string.Empty;
        public string OpenTime {get; set;} = string.Empty;
        public string CloseTime {get; set;} = string.Empty;
        public string Url {get; set;} = string.Empty;

        public int PoolOwnerId {get; set;}
        [ForeignKey("PoolOwnerId")]
        public User? PoolOwner {get; set;}
        public List<EventOfPool>? EventOfPools {get; set;}
        public List<Ticket>? Tickets {get; set;}
        public List<BusTicket>? BusTickets {get; set;}
    }
}