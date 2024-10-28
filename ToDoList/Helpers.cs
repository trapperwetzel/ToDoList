using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Helpers
    {
        static List<string> userToDoList = new List<string>();

        // get users name
        internal static string getName()
        {
            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Hello {name} and welcome back to your To-Do-List");
            Console.WriteLine("----------------------------------------------------");

            return name;

        }

        // Add users entry to the todolist.
        public static void AddToList()
        {
            Console.WriteLine("Enter new entry to your list: ");
            Console.WriteLine("Enter the word: 'quit' to quit");
            var entry = Console.ReadLine();
            userToDoList.Add(entry);
            while (entry != "quit")
            {
 
                Console.WriteLine("Enter next entry, or type 'quit' to leave");
                entry = Console.ReadLine();
                userToDoList.Add(entry);

            }
            
            
            
            
        }

        public static void printUserToDoList()
        {
            foreach(string item in userToDoList)
            {
                Console.WriteLine($"- {item}");
                Console.WriteLine();
            }
        }

    }
}
