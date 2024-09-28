using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class Pool
    {
        public int PoolId { get; set; }
        public string PoolName {get; set; } = string.Empty;
    }
}