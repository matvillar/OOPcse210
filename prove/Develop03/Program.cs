using System;


class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("John", 3, 16, 18);
        Console.WriteLine(reference.StringifyRef());

        Scripture newScript = new Scripture(reference, new Word());

Console.WriteLine("Press any key to hide a random word or press 'Q' to quit");
       while (Console.ReadKey().Key != ConsoleKey.Q  )

         {
       newScript.HideWord();
    

         }
    }
}