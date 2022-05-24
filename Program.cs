// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int userInput;
            Boolean isNumber = true;

            //prompt for test
            Console.WriteLine("Which test do you want to take?");
            Console.WriteLine("Please enter number 1 - 4 ");
            userInput = int.Parse(Console.ReadLine());

            do
            {
                //validating user input
                if (userInput == 1 || userInput == 2 || userInput == 3 || userInput == 4)
                {
                    isNumber = true;
                }else
                {
                    //prompting until correct input
                    Console.WriteLine("Which test do you want to take?");
                    Console.WriteLine("Please enter number 1 - 4 ");
                    isNumber = false;
                    userInput = int.Parse(Console.ReadLine());
                }
                } while (!(isNumber));

            //passing variable to Class1 class
            Class1 testChoice = new Class1(userInput);
        }
    }
}
