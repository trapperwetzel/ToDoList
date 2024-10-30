using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Helpers
    {


        internal static string getName()
        {
            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Hello {name} and welcome back to your To-Do-List");
            Console.WriteLine("----------------------------------------------------");

            return name;

        }

        internal static string GetUserToDoListFromFile()
        {
            var result = File.ReadAllLines("C:\\Users\\THINKPADENJOYER420\\Desktop\\Projects\\ToDoList\\ToDoList\\userList.txt");
            string message = "";
            
            foreach (string line in result)
            {
                message += "\n";
                message += $"{line}";
                


            }
            return message;
        }



    }
}
