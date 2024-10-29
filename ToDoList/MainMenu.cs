using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList;

namespace ToDoList
{
    internal class MainMenu
    {
        
        public static void Menu()
        {
            var name = Helpers.getName();

            Console.WriteLine("Would you like to use your previous To-Do-List?");
            var previouslist = Console.ReadLine();
            if (previouslist.Trim().ToLower() == "yes")
            {
                Helpers.AddPreviousList();
                Helpers.SeeList();
            }
            

            Console.WriteLine("Enter 'a' to add to your list");
            Console.WriteLine();
            var input = Console.ReadLine();
            if (input.Trim().ToLower() == "a")
            {
                Console.Clear();
                Helpers.AddToList();
                
            }

            // Add user list to a text file
            Helpers.AddToFile();

            // Ask user if they want to see List
            Helpers.SeeList();

        }

        







    }
}
