using System;
using System.Collections.Generic;
using System.Text;

namespace Chores
{
    public class ChoresCLI
    {
        const string Command_AddChores = "1";
        const string Command_CheckWeeklyBalance = "2";
        const string Command_CloseOutWeek = "3";
        const string Command_Quit = "q";

        public void RunCLI()
        {
            PrintHeader();
            PrintMenu();
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

        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
