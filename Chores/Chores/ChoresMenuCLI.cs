using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ChoresProjects.Models;
using ChoresProjects.DAL;

namespace ChoresProjects
{
    public class ChoresMenuCLI
    {
        const string Command_ViewChores = "1";
        const string Command_AddCompletedChore = "2";
        const string Command_CheckBalance = "3";
        const string Command_CloseOutWeek = "4";
        const string Command_Quit = "q";
        private IUsersDAO usersDAO;
        private IChoresDAO choresDAO;
        private IPayoutDAO payoutDAO;
        string name = "";

        public ChoresMenuCLI(IUsersDAO usersDAO, IChoresDAO choresDAO, IPayoutDAO payoutDAO)
        {
            this.usersDAO = usersDAO;
            this.choresDAO = choresDAO;
            this.payoutDAO = payoutDAO;
        }

        public void RunCLI()
        {
            PrintHeader();
            FindName();
            PrintMenu();

            while (true)
            {
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice.ToLower())
                {
                    case Command_ViewChores:
                        ViewChores();
                        break;

                    case Command_AddCompletedChore:
                        AddCompletedChore();
                        break;

                    case Command_CheckBalance:
                        Checkbalance();
                        break;

                    case Command_CloseOutWeek:
                        CloseWeek();
                        break;

                    case Command_Quit:
                        Console.WriteLine("GoodBye!!");
                        return;

                    default:
                        Console.WriteLine("Please select a valid option");
                        break;
                }
                PrintMenu();
            }
        }
        public void PrintHeader()
        {
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"         $$$$$$\  $$\                                            ");
            Console.WriteLine(@"        $$  __$$\ $$ |                                           ");
            Console.WriteLine(@"        $$ /  \__|$$$$$$$\   $$$$$$\   $$$$$$\   $$$$$$\   $$$$$$$\ ");
            Console.WriteLine(@"        $$ |      $$  __$$\ $$  __$$\ $$  __$$\ $$  __$$\ $$  _____|");
            Console.WriteLine(@"        $$ |      $$ |  $$ |$$ /  $$ |$$ |  \__|$$$$$$$$ |\$$$$$$\");
            Console.WriteLine(@"        $$ |  $$\ $$ |  $$ |$$ |  $$ |$$ |      $$   ____| \____$$\");
            Console.WriteLine(@"        \$$$$$$  |$$ |  $$ |\$$$$$$  |$$ |      \$$$$$$$\ $$$$$$$  |");
            Console.WriteLine(@"         \______/ \__|  \__| \______/ \__|       \_______|\_______/ ");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
        }
        public void FindName()
        {
            Console.WriteLine("Who are you?");
            name = Console.ReadLine();

        }
        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What would you like to do " + name + " ? ");
            Console.WriteLine(" 1 - Look at a list of all chores");
            Console.WriteLine(" 2 - Add a completed chore");
            Console.WriteLine(" 3 - Check how much you have earned this week");
            Console.WriteLine(" 4 - Close out week");
            Console.WriteLine(" Q - Quit");
            Console.WriteLine();
        }
        public void ViewChores()
        {
            IList<Chores> chores = choresDAO.GetChores();

            Console.WriteLine();
            Console.WriteLine("List O Chores");

            for(int i = 0; i < chores.Count; i++) 
            {
                Console.WriteLine(" - "+chores[i]);
                Console.WriteLine();
            }
        }
        public void AddCompletedChore()
        {
            ViewChores();
            Console.WriteLine("Which chore number did you complete");
            string choreSelection = Console.ReadLine();
            int chore = int.Parse(choreSelection);
            Console.WriteLine("What is your school ID number");
            string schoolNumber = Console.ReadLine();
            int number = int.Parse(schoolNumber);
            Payout choice = new Payout
            {
                choresId=chore,
                userId=number
            };
            bool result = payoutDAO.CompletedChore();
            
        }
        public void Checkbalance()
        {
        }
        public void CloseWeek()
        {
        }


    }
}
