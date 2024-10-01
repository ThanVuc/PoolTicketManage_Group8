using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}
        public string UserName {get; set;} = string.Empty;
        public string Password {get; set;} = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string CreatedDate { get; set; } = string.Empty;

        public List<Bill>? Bills {get; set;}
        public List<Question>? Questions {get; set;}
        public List<UserRole>? UserRoles {get; set;}
        public List<CartItem>? CartItems {get; set;}
        public List<Pool>? Pools {get; set;}
    }
}