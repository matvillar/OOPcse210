using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
            
        }
        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
           int squaredNumber =  SquareNumber(userNumber);
            return squaredNumber;
        }
        static int SquareNumber(int userNumber)
        {
            int squaredNumber = userNumber * userNumber;
            return squaredNumber;
        }
        static void DisplayResult()
        {
           string userName = PromptUserName();
              int squaredNumber = PromptUserNumber();

            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
            
        }
        DisplayWelcome();
        DisplayResult();
    }
}