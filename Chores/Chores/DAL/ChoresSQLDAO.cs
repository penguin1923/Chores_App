using ChoresProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public IList<Chores> GetChores()
        {
            IList<Chores> choreList = new List<Chores>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    string sqlStatement = "select * from chores";
                    sqlCommand.CommandText = sqlStatement;
                    sqlCommand.Connection = connection;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Chores chore = new Chores();
                        chore.choresId = Convert.ToInt32(reader["choresId"]);
                        chore.chore_title = Convert.ToString(reader["chore_title"]);
                        chore.chore_description = Convert.ToString(reader["chore_description"]);
                        chore.chore_payout = Convert.ToDecimal(reader["chore_payout"]);
                        choreList.Add(chore);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("something bad happened");
            }
            return choreList;
        }
    }
}
