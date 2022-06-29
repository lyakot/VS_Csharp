using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player
    {
        private int health = 10;
        private int mana = 10;

        private Item[] inventory;

        
    
       
        public Player()
        {
            inventory = new Item[10];
            health = 10;
            mana = 10;

            for (int i = 0; i < inventory.Length; i++)
            {
                if (i <5)
                {
                    inventory[i] = new Potion();
                }
                else
                {
                    inventory[i] = new Apple();
                }
            }


        }

     public void Eat()
        {
        for (int i = 0; i < inventory.Length; i++)
            {
                Item item = inventory[i];
                if (item is IEatable)
                {
                    health += (item as IEatable).Eat();
                    inventory[i] = null;
                    Console.WriteLine($"You ate an {item}");
                    Console.WriteLine($"You're player has {mana} mana and {health} health");
                    return;
                }

            }
            Console.WriteLine("You have no eatable items left");
        }

        public void Drink()
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Item item = inventory[i];
                if (item is IDrinkable)
                {
                    mana += (item as IDrinkable).Drink();
                    inventory[i] = null;
                    Console.WriteLine($"You drink a {item}");
                    Console.WriteLine($"You're player has {mana} mana and {health} health");
                    return;
                }

            }
            Console.WriteLine("You have no drinkable items left");
        }




        public void InventoryStatus()
        {
            Console.WriteLine("Inventory contains: ");
            int count = 1;
            for (int i = 0; i < inventory.Length; i++)
            {
                
                if (inventory[i] != null)
                {
                    Console.WriteLine($"{count}.{inventory[i]}");
                    count++;
                }
                
            }
        }

    }
}
