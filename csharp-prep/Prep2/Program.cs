using System;


class Program
{
    static void Main(string[] args)
    {
        //    Console.Write("Enter a Number:");
        //      int num1 = int.Parse(Console.ReadLine()); // int.Parse & Convert.ToInt32 converts to int
        //      Console.WriteLine($"You entered {num1}");
        //     //  Get type of num1
        //     Console.WriteLine($"Type of num1 is {num1.GetType()}");
        // Ask user for the grade
        Console.Write("Enter your grade: ");
        string userInput = Console.ReadLine();
        // Convert userGrade to int
        int grade = int.Parse(userInput);
        string letterGrade;


         if (grade >= 90) 
         {
            letterGrade = "A";
            if (grade <= 92) 
            {
                letterGrade += "-";
            }
        } else if (grade >= 80) 
        {
            letterGrade = "B";
            if (grade >= 87) 
            {
                letterGrade += "+";
            } else if (grade <= 82) {
                letterGrade += "-";
            }
        } else if (grade >= 70) 
        {
            letterGrade = "C";
            if (grade >= 77) {
                letterGrade += "+";
            } else if (grade <= 72) {
                letterGrade += "-";
            }
        } else if (grade >= 60)
        {
            letterGrade = "D";
            if (grade >= 67) 
            {
                letterGrade += "+";

            } else if (grade <= 62) 
            {
                letterGrade += "-";
            }
        } else 
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}"); // Ask why when I dont finish with an else statement letterGrade is not defined
       
       if(grade >= 60 )
       {
              Console.WriteLine("You passed!");
         } else 
         {
              Console.WriteLine("You failed!"); 
       }
        
    }
}