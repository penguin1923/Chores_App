using ChoresProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace ChoresProjects.DAL
{
    public class ChoresSQLDAO : IChoresDAO
    {
        private string connectionString;

        public ChoresSQLDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public IList<Chores> choreNames = new List<Chores>();

        string s = "poop";
        public string ChoresList(string name)
        {//Pull in chores list from database
            return s;
        }

        public string AddChore()
        {//SQL add statement
            return s;
        }
    }
}
