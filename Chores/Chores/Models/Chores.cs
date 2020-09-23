using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ChoresProjects.Models
{
    public class Chores
    {
        public int choresId { get; set; }
        public string chore_title { get; set; }
        public string chore_description { get; set; }
        public decimal chore_payout { get; set; }

        public override string ToString()
        {
            //return choresId;
            return choresId.ToString().PadRight(4) + chore_title.ToString().PadRight(20) + chore_payout.ToString("C").PadRight(8) + chore_description.ToString().PadLeft(50) ;
        }
    }
}

