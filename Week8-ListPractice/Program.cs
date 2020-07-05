using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array that holds 3 integers
            int[] ints = new int[3];

            //declare and initialize a list of student names
            List<string> studentNames = new List<string>();
            
            //declare and initialize a list of integers
            List<int> integers = new List<int>();

            //declare and initialize a list of doubles
            List<double> doublenum = new List<double>();

            //declare and initialize a list of character (chars)
            List<char> letters = new List<char>();
            Console.ReadLine();

            List<string> myGroceryList = new List<string>();

            myGroceryList.Add("Milk");
            myGroceryList.Add("Bread");
            myGroceryList.Add("Bacon");

            //declaring and initalizing a list of student grades
            List<double> studentGrades = new List<double>();

            //each line here is adding a new grade to the list of student grades
            studentGrades.Add(88.5);
            studentGrades.Add(75.3);
            studentGrades.Add(98.7);
            studentGrades.Add(100.0);
            studentGrades.Add(66.8);
            Console.WriteLine(studentGrades[1]);


            List<string> studentList = new List<string> { "Lee", "Hemory", "Alan" };

            studentList.Add("Alan");

            Console.WriteLine(studentList[2]);
            
            foreach(string student in studentList)
            {
                Console.WriteLine(student);
            }
            List<string> studentNames2 = new List<string>();

            Console.WriteLine("Give me a name of a student?");
            string name = Console.ReadLine();

            studentNames2.Add(name);

            foreach(string names in studentNames2)
            { 
                Console.WriteLine(names);
            
            }

            List<string> myGroceryList2 = new List<string>();
            Console.WriteLine("Please enter an item on your grocery list:");
            string item = Console.ReadLine();
            myGroceryList.Add(item);
            Console.WriteLine("You entered: " + item);
           
            Console.WriteLine("Would you like to add another item? Y or N?");
            Console.ReadLine();
            foreach (string item in myGroceryList2)
            {
                Console.WriteLine(item);

            }










        }
    }
}
