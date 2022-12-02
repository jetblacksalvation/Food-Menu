using System;
using System.Collections.Generic;
namespace brrruh
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int food = 0;
            int potion = 1;
            int sword = 2;
            Dictionary<int, string> store = new Dictionary<int, string>(new List<KeyValuePair<int, string>>() { 
                new KeyValuePair<int, string>(5, "food"),
                new KeyValuePair<int, string>(10, "potion"),
                new KeyValuePair<int, string>(15, "sword ")
            
            });
            List<int> Inventory = new List<int> { 0, 0, 0 };
            string input = new string(" ");
            int cash = 50;
            while (input != "q" && cash >0)
            {
                Console.WriteLine("Would You Like to buy A ... Or Look At (Inv)entory?");
                Console.WriteLine("You Have {0} Dollars", cash);
                foreach (var it in store.data)
                {
                    
                    Console.WriteLine(string.Format( " A {0} For {1} ",it.Value,it.Key));
                    //bruh.Key;
                }
                input = Console.ReadLine();
                if (input == "Inv" )
                {

                    Console.WriteLine("you have {0 } foods ", Inventory[food]);
                    Console.WriteLine("you have{0} potions", Inventory[potion]);
                    Console.WriteLine("you have{0} swords", Inventory[sword]);

                }
                foreach (var it in store.data)
                {
                    if(input == it.Value)
                    {
                        Console.WriteLine("A {0} Costs {1}, are you sure?", it.Value, it.Key);
                        while (true) {

                            Console.WriteLine("(Y)es , (N)o");
                            input = Console.ReadLine();

                            if (input == "y" || input == "Y")
                            {
                                cash -= it.Key;
                                if(it.Value == "food")
                                {
                                    Inventory[food] += 1;
                                }
                                if (it.Value == "potion")
                                {
                                    Inventory[potion] += 1;
                                }
                                if (it.Value == "sword")
                                {
                                    Inventory[sword] += 1;
                                }
                                Console.WriteLine("You Have {0} Cash Left", cash);
                                break;

                            }
                            else if (input == "n" || input == "N")
                            {
                                Console.WriteLine("Ok...");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("I did not understand that");
                            }
                        }
                    }
                    //bruh.Key;
                }
            }
        }
    }
}
