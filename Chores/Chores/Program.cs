using System;

namespace Chores
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChoresCLI cli = new ChoresCLI();
            cli.RunCLI();
        }

        public string CanItStart()
        {
            string yes = "yes";
            return yes;
        }


    }
}