using System;
// 1. I wanted to have a separate file with the Readsize() method so that it wouldn't clog up my main file.
// Copilot told me that it's not possible in C# without having the method within a class or a struct.
// It suggested to put Readsize() inside a class which treats the said class and my main (Program) as "one unified class" by using the keyword "partial".
// To make it work this file needs to have the same namespace as in my main.
// This is the solution:

namespace Project_Chessboard
{ 
    partial class Program
    {
        static int ReadSize()
        {

            int number;

            while(true)
            {
                Console.WriteLine("Please input a number between 3 and 50. The number will determine the size of the chessboard");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("You must write a valid number, try again");
                    continue;
                }

                if (number < 3 || number > 50)
                {
                    Console.WriteLine("The number is outside the accepted interval, try again");
                    continue;
                }

                break;
            }
            return number;

        }

    }

}
