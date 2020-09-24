using ChoresProjects.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChoresProjects.DAL
{
    public interface IPayoutDAO
    {
        public bool ComepletedChore(Payout choice);
    }
}
