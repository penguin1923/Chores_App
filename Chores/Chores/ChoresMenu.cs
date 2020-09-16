using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chores
{
    public class ChoresMenu
    {
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
        string name = "";
        public void FindName()
        {
            PrintHeader();
            Console.WriteLine("Who are you?");
            name = Console.ReadLine();
            Console.Clear();
            WhatIsYourMission();
        }


        public void WhatIsYourMission() 
        {
            PrintHeader();
            Console.WriteLine("What would you like to do "+name+"?");
            Console.WriteLine("1--Add a chore I have completed");
            Console.WriteLine("2--Check how I am doing this week?");
            Console.WriteLine("3--Close my week out");
            Console.WriteLine("Q--Quit this program");
            string option = Console.ReadLine().ToLower();

            if(option == "1") 
            {

            }
            else if(option == "2") 
            {

            }
            else if (option == "3") 
            {

            }
            else if(option=="q")
            {
                return;
            }
            else
            {
                InvalidMission();
            }

        }
        public void InvalidMission()
        {
            Console.Clear();
            WhatIsYourMission();
        }
    }
}
