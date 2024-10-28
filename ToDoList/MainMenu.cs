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
            Console.WriteLine("Would you like to add to your list?");
            var input = Console.ReadLine();
            if (input == "yes")
            {
                Helpers.AddToList();
            }


            Console.WriteLine("Would you like to see your list?");
            var input1 = Console.ReadLine();
            if(input1 == "yes")
            {
                Console.Clear();
                Console.WriteLine("Here is your list: \n");
                Helpers.printUserToDoList();
            }

            
        }

       




        

    }
}
