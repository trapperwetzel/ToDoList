using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class User
    {



        // gets and sets for each person who uses the To-Do-List
        public string Name { get; set; }
        static public List<string> UserToDoList { get; set; }



        // Constructor 
        public User(string aName, List<string> AUserToDoList)
        {
            Name = aName;
            UserToDoList = AUserToDoList;
        }


        // Methods

        internal void AddItem(string entry)
        {
            UserToDoList.Add(entry);
        }


        
        internal void AddPreviousList()
        {
            var previousToDoList = Helpers.GetUserToDoListFromFile();
            UserToDoList.Add(previousToDoList);
        }


        

        internal void SeeList()
        {
            Console.WriteLine("Enter 'y' to see list  ");
            var input1 = Console.ReadLine();
            if (input1.Trim().ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine("Here is your list: ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(Helpers.GetUserToDoListFromFile().Trim());
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();

            }
        }

        internal void AddToFile()
        {

            File.WriteAllText("C:\\Users\\THINKPADENJOYER420\\Desktop\\Projects\\ToDoList\\ToDoList\\userList.txt", printUserToDoList());
        }


        internal static string printUserToDoList()
        {
            string message = "";
            foreach (string item in UserToDoList)
            {
                message += ($"{item}");
                message += "\n";


            }
            return message;
        }







    }
}
