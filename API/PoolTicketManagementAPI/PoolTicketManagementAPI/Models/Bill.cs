using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class Bill
    {
        public int BillId {get; set;}
        public string BillName {get; set;} = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string PaymentMethod { get; set; } = string.Empty;
        public int UserId {get; set;}

        [ForeignKey("UserId")]
        public User? User {get; set;}

    }
}