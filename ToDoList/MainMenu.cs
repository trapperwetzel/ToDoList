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
            List<string> usersList = new List<string>();
            User user = new User(name, usersList);


            
            Console.WriteLine("Would you like to use your previous To-Do-List?");
            var previouslist = Console.ReadLine();
            if (previouslist.Trim().ToLower() == "yes")
            {
                user.AddPreviousList();
                user.SeeList();
            }
            

            Console.WriteLine("Enter 'a' to add to your list");
            Console.WriteLine();
            var input = Console.ReadLine();
            if (input.Trim().ToLower() == "a")
            {
                Console.Clear();
                Console.WriteLine("Enter new entry to your list: ");
                Console.WriteLine("Enter the word: 'quit' to quit");
                var entry = Console.ReadLine();
                user.AddItem(entry);
                while (entry != "quit")
                {

                    Console.WriteLine("Enter next entry, or type 'quit' to leave");
                    entry = Console.ReadLine();
                    if (entry != "quit")
                    {
                        user.AddItem(entry);
                    }


                }
            }

                // Add user list to a text file
            user.AddToFile();

            // Ask user if they want to see List
            user.SeeList();

        }









    }
}