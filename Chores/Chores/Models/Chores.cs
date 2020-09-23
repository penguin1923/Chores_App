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

    public override string ToString() 
    {//try out the padding to see if/how it works
        return choresId.ToString().PadRight(4) + chore_title.ToString().PadRight(50) + chore_description.ToString().PadRight(50) + chore_payout.ToString().PadRight(4);
    }
}

