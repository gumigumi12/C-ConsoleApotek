using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2M1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.WriteLine("----------------------Main Menu For---------------------");
                    Console.WriteLine("========================================================");
                    Console.WriteLine("+++              1)      Supplier                    +++");
                    Console.WriteLine("+++              2)      Cashier                     +++");
                    Console.WriteLine("+++              3)      Quit                        +++");
                    Console.WriteLine("========================================================");
                    Console.WriteLine("please enter the menu for :");
                    int selected = Convert.ToInt32(Console.ReadLine());
                    {
                        switch (selected)
                        {
                            case 1:
                                Console.WriteLine("========================================================");
                                Console.WriteLine("+++                    Supplier                      +++");
                                Console.WriteLine("========================================================");
                                break;
                            case 2:
                                Console.WriteLine("========================================================");
                                Console.WriteLine("+++                    Cashier                       +++");
                                Console.WriteLine("========================================================");
                                break;
                            case 3:
                                Console.WriteLine("========================================================");
                                Console.WriteLine("----------------------Thanks You------------------------");
                                Console.WriteLine("========================================================");
                                return;
                        }
                    }
                }
            }
        }
    }
}
