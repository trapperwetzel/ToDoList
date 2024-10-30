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
            Console.Clear();
            bool isAppOn = true;
            do
            {
                user.SeeList();
                Console.WriteLine();
                Console.WriteLine("Please enter your choice from below: ");
                Console.WriteLine("----------------------------------");
                
                Console.WriteLine("" +
                    "A - Add to your list\n" +
                    "R - Remove a item from your list\n" +
                    "E - Exit\n");
                Console.WriteLine("----------------------------------");

                var userchoice = Console.ReadLine();

                switch (userchoice.Trim().ToLower())
                {



                    case "a":
                        Console.Clear();
                        Console.WriteLine("Enter new entry to your list: ");
                        Console.WriteLine("Enter the word: 'quit' to quit");
                        var entry = Console.ReadLine();
                        user.AddItem(entry);
                        while (entry != "quit")
                        {

                            Console.WriteLine("Enter new entry, or type 'quit' to leave");
                            entry = Console.ReadLine();
                            if (entry != "quit")
                            {
                                user.AddItem(entry);
                            }
                        }
                        break;


                    case "r":
                        Console.WriteLine("Enter number of item you want to remove");
                        user.RemoveFromList(int.Parse(Console.ReadLine()));
                        break;

                    case "e":
                        Console.WriteLine("Thank you for using this To Do List");
                        isAppOn = false;
                        Environment.Exit(1);
                        break;


                }

                // Add user list to a text file
                user.AddToFile();



                Console.WriteLine("Would you like to see your finished list? ");
                var useryesorno = Console.ReadLine();
                if (useryesorno.Trim().ToLower() == "yes")
                {
                    user.SeeList();
                }
            }

            while (isAppOn);
            
            

        }









    }
}