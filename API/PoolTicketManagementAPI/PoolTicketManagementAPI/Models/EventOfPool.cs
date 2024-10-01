using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class EventOfPool
    {
        public int PoolId { get; set; }
        public int EventId { get; set; }
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}

        [ForeignKey("PoolId")]
        public Pool? Pool {get; set;}
        [ForeignKey("EventId")]
        public Event? Event {get; set;}
    }
}