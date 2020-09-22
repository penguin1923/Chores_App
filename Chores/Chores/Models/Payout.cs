using System;
using System.Collections.Generic;
using System.Text;

namespace Chores.Models
{
    public class Payout
    {
        public int transactionId { get; set; }
        public int userId { get; set; }
        public int choresId { get; set; }
    }
}
