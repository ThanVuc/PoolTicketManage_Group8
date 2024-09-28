using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoolTicketManagementAPI.Models
{
    public class Question
    {
        public int QuestionId {get; set;}
        public string QuestionName {get; set;} = string.Empty;
        public string QuestionContent {get; set;} = string.Empty;
        public long View {get; set;}
        public bool IsFAQ {get; set;}
        public int UserId {get; set;}
        [ForeignKey("UserId")]
        public User? User {get; set;}
    }
}