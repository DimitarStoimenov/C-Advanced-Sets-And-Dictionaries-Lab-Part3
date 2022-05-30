using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop_Dictionaries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> output = new HashSet<string>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] rawCommand = command.Split(", ");

                if (rawCommand[0] == "IN")
                {

                    output.Add(rawCommand[1]);
                }
                else if (rawCommand[0] == "OUT")
                {
                    output.Remove(rawCommand[1]);
                }

                command = Console.ReadLine();
            }
            if (output.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in output)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

