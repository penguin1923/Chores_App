using System;
using System.Collections.Generic;
using System.Text;
using ChoresProjects.Models;

namespace ChoresProjects
{
    public interface IChoresDAO
    {
        IList<Chores> GetChores();
    }
}
