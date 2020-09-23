using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using ChoresProjects.DAL;

namespace ChoresProjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("Chores");

            IUsersDAO usersDAO = new UsersSQLDAO(connectionString);
            IPayoutDAO payoutDAO = new PayoutSQLDAO(connectionString);
            IChoresDAO choresDAO = new ChoresSQLDAO(connectionString);


            ChoresMenuCLI chores = new ChoresMenuCLI(usersDAO,choresDAO,payoutDAO);
            chores.RunCLI();
        }
    }
}