using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

                Console.Clear();
                Console.WriteLine("Here is your list: ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(Helpers.GetUserToDoListFromFile().Trim());
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
            
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
                message += $"{item}";
                message += "\n";
                

            }
            return message;
        }

        internal  void RemoveFromList(int number)
        {
            for(int i = 0; i < UserToDoList.Count; i++)
            {
                if(i  == number -1 )
                {
                    UserToDoList.Remove(UserToDoList[i]);
                    break;
                }
            }
        }






    }
}
