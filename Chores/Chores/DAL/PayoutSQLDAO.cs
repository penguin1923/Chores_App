using System;
using System.Collections.Generic;
using System.Text;
using ChoresProjects.Models;

namespace ChoresProjects.DAL
{
    public class PayoutSQLDAO : IPayoutDAO
    {
        private string connectionString;

        public PayoutSQLDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }
    }
}
