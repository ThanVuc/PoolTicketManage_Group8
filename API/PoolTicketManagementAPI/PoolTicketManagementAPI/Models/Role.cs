using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName {get; set;} = string.Empty;
        public string Description {get; set;} = string.Empty;

        public List<UserRole>? UserRoles {get; set;}
    }
}