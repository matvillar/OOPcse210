using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What's your first name? ");
        // string firstName = Console.ReadLine();
        // Console.Write("What's your last name? ");
        // string lastName = Console.ReadLine();
        // Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
        List<int> numList = new List<int> {2,4,6,12,1,9,7, 10, 3, 5, 8, 11};
        int currentPosition = 0;
        int currentNum = numList[currentPosition];
        Console.WriteLine(numList.Count);
        

        if ( currentPosition != numList.Count -1)
        {

           int nextNumber = numList[currentPosition + currentNum];
           Console.WriteLine($"currentNum {currentNum} currentPos {currentPosition}");
           
           Console.WriteLine($"firstnexrNum {nextNumber}");
           
           currentPosition = currentPosition + nextNumber;
           
           Console.WriteLine($"next currentPos {currentPosition}");
           
        
           Console.WriteLine($"nextNum {currentNum}");
           
          
          
            
            
        }
    }
}