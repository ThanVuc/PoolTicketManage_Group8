using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class User
    {
        public int UserId {get; set;}
        public string UserName {get; set;} = string.Empty;
        public string Password {get; set;} = string.Empty;

    }
}