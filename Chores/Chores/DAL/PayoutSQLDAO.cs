using ChoresProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ChoresProjects.DAL
{
    public class PayoutSQLDAO : IPayoutDAO
    {
        private string connectionString;

        public PayoutSQLDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }
        public bool ComepletedChore(Payout choice)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into payout VALUES(@userId,@choresId);", conn);
                    cmd.Parameters.AddWithValue("@userId",choice.userId );
                    cmd.Parameters.AddWithValue("@choresId", choice.choresId);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error inserting the new language");
                return false;
            }
            return true;
        }

    }
}

