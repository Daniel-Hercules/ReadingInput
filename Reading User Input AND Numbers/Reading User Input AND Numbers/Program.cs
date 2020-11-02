using System;
using System.Xml;

namespace Reading_User_Input_AND_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");

            // Reads User Input and Stores input in "name"
            // String variable.
            
            String name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");

            // Reads user input and converts input into a number.
            // (Only Strings can be read without additional methods 
            // needing to be used)

            int age = Convert.ToInt32(Console.ReadLine());

            //Prints User Input 

            Console.WriteLine("Hi " + name + "!" + " You are " + age + " years old.");
        }
    }
}
