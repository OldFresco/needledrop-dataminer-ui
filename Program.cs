using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataMinerConsoleUI ui = new DataMinerConsoleUI();
            ui.UseDefaultLayout();           
            ui.RefresView();
             
            bool exit = false;
            do
            {
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ui.RefresView();
                        break;
                    case "2":
                        ui.RefresView();
                        break;
                    case "3":
                        ui.RefresView();
                        break;
                    case "4":
		                Console.WriteLine("K, Bye!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, not happening! Try again.");
                        ui.RefresView();
                        break;
                }
                Console.WriteLine();    
            } while (exit == false);                                                                
        }
    }
}
