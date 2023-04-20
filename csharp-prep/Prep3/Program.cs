using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain= "y";
        Random randomNumberGen = new Random();
        int randomNum = randomNumberGen.Next(1, 101);

    while(playAgain == "y")
    {
        Console.Write($"Enter a random number between 1 and 100: ");
        int userInput = int.Parse(Console.ReadLine());
        int counter = 0;
          
          while(userInput != randomNum)
          {
            if (userInput > randomNum)
            {
                Console.WriteLine($"Lower");
                counter++;
            } else if (userInput < randomNum)
            {
                Console.WriteLine($"Higher");
                counter++;
            }
          
            userInput = int.Parse(Console.ReadLine());
                   
          }
           Console.WriteLine($"Good Job the magic number was {randomNum}");
           Console.WriteLine($"It took you {counter} tries");
            
     
        Console.Write($"Would you like to play again? (y/n): ");
        playAgain = Console.ReadLine();
        
    } 
    Console.WriteLine($"Thanks for playing!");
    


    //    While Loops - While loops are used to execute a block of code as long as a condition is true

        // string userInput = "";
        // while (userInput == "" )
        // {
        //     Console.WriteLine($"Enter your name:");
        //     userInput = Console.ReadLine();
        // }
        // Console.WriteLine($"Hello {userInput}");

    // For loop - For loops are used to execute a block of code a specific number of times

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine($"Hello {i}");
        // }    

    // For each loop - For each loops are used to execute a block of code once for each item in a collection

        //  List<string> names = new List<string>() {"John", "Dane", "Joe", "Pill"};
        //  List<int> numbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        //  foreach(string name in names){
        //         if (name[0] != 'J')
        //         {
        //             Console.WriteLine($"Text: {name}");
        //         }
        //  }
        //  foreach(int num in numbers){
        //     int numTimesTwo = num * 2;
        //     Console.WriteLine($"Number: {numTimesTwo}");
        //  }
    }
}