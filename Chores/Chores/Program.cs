using Microsoft.Extensions.Configuration;
using System.IO;
using System;


namespace Chores
{
    public class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("World");

            IUsersDAO usersDAO = new UsersSQLDAO(connectionString);
            IPayoutDAO payoutDAO = new PayoutSQLDAO(connectionString);
            IChoresDAO choresDAO = new ChoresSQLDAO(connectionString);
          

            ChoresMenu chores = new ChoresMenu();
            chores.FindName();
        }
    }
}