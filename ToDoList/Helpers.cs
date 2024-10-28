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
        internal static void AddToList()
        {
            Console.WriteLine("Enter new entry to your list: ");
            Console.WriteLine("Enter the word: 'quit' to quit");
            var entry = Console.ReadLine();
            userToDoList.Add(entry);
            while (entry != "quit")
            {
 
                Console.WriteLine("Enter next entry, or type 'quit' to leave");
                entry = Console.ReadLine();
                if(entry != "quit") 
                { 
                    userToDoList.Add(entry); 
                }
                

            }
            
        }


        internal static void AddToFile()
        {
            
            File.WriteAllText("C:\\Users\\THINKPADENJOYER420\\Desktop\\Projects\\ToDoList\\ToDoList\\userList.txt", printUserToDoList());
        }

        internal static string GetUserToDoListFromFile()
        {
            var result = File.ReadAllLines("C:\\Users\\THINKPADENJOYER420\\Desktop\\Projects\\ToDoList\\ToDoList\\userList.txt");
            string message = "";
            foreach(string line in result)
            {
                message += line;
                message += "\n";
            }
            return message;
        }
        internal static void SeeList()
        {
            Console.WriteLine("Would you like to see your list?");
            Console.WriteLine("\n");
            Console.WriteLine("Enter 'y' to see list  ");
            var input1 = Console.ReadLine();
            if (input1.Trim().ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine("Here is your list: \n");
                Console.WriteLine(Helpers.GetUserToDoListFromFile());
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                
            }
        }


        internal static void RemoveFromList()
        {

        }


        internal static string printUserToDoList()
        {
            string message = "";
            foreach(string item in userToDoList)
            {
                message += ($"- {item}");
                message += "\n";

                
            }
            return message;
        }

    }
}
