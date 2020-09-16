using System;

namespace Chores
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChoresMenu cli = new ChoresMenu();
            cli.FindName();
        }

        public string CanItStart()
        {
            string yes = "yes";
            return yes;
        }


    }
}