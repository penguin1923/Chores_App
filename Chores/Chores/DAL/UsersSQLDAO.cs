using System;
using System.Collections.Generic;
using System.Text;
using ChoresProjects.Models;

namespace ChoresProjects.DAL
{
    public class UsersSQLDAO : IUsersDAO
    {
        private string connectionString;

        public UsersSQLDAO(string databaseconnectionString) 
        {
            connectionString = databaseconnectionString;
        }
    }
}
