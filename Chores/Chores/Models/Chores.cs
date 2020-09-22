using System;
using System.Collections.Generic;
using System.Text;

namespace Chores.Models
{
    public class Chores
    {
        public int choresId { get; set;}
        public string chore_title { get; set; }
        public string chore_description { get; set; }
        public decimal chore_payout { get; set; }
    }
}
