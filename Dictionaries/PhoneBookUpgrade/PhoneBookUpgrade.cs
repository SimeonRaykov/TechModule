using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class PhoneBookUpgrade
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    string name = commands[1];
                    string phoneNumber = commands[2];

                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phoneNumber;
                    }
                    else
                    {
                        phonebook.Add(name, phoneNumber);
                    }

                }
                else if (commands[0] == "S")
                {
                    string name = commands[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[commands[1]]} ");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }

                }
                else if (commands[0] == "ListAll")
                {
                    foreach (KeyValuePair<string, string> phone in phonebook.OrderBy(x=>x.Key))
                    {

                        Console.WriteLine($"{phone.Key} -> {phone.Value}");

                    }
                }

                
                    commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            }






        }
    }
}

