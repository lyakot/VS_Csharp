using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Player p = new Player();
            
            while (true)
            {
                Console.WriteLine("1. Inventory Status");
                Console.WriteLine("2. Eat");
                Console.WriteLine("3. Drink");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        p.InventoryStatus();
                        break;
                    case 2:
                        p.Eat();
                        break;
                    case 3:
                        p.Drink();
                        break;

                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            



        }
    }
}


    
                
            
