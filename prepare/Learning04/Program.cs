using System;

class Program
{
    static void Main(string[] args)
    {
    //   Assignment assignment = new Assignment("John", "Math");
    //     Console.WriteLine(assignment.GetSummary());

    //   MathAssignment mathAssignment = new MathAssignment("pablo", "Math", "Chapter 3", "10");
    //     Console.WriteLine(mathAssignment.GetHomeworkList());
    //     Console.WriteLine($"Text {mathAssignment.GetSummary()}");

    WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
    Console.WriteLine($"Text {writingAssignment.GetSummary()}");
    
    Console.WriteLine(writingAssignment.GetWritingInformation());
        
    }
}