using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // List vs Array - Arrays are fixed in size, Lists are dynamics can increase or decrease

        // String[] foods = new string[3];

        // foods[0] = "Pizza";
        // foods[1] = "Hamburger";
        // foods[2] = "Hot Dog";
        // foods[3] = "Taco";

        // foreach (String food in foods) // Whats the differences string and String?
        // {
        //     Console.WriteLine(food);
        // }

        //LISTS

        // List<String> foods = new List<String>();

        // foods.Add("Pizza");
        // foods.Add("Hamburger");
        // foods.Add("Hot Dog");
        // foods.Add("Taco");

        // foods.Remove("Hot Dog");
        // foods.Insert(0, "susshi");
        // Console.WriteLine(foods.Count);
        // Console.WriteLine(foods.IndexOf("Pizza"));
        // Console.WriteLine(foods.Contains("Pizza"));
        //    foods.Sort();
        // foods.Reverse();
        // foods.Clear();

        // Assignment 
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        Console.Write("Enter a number: ");
        
        List<int> numList = new List<int>();
        int userInput = int.Parse(Console.ReadLine());
        while (userInput != 0)
        {
             numList.Add(userInput);
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

           
        } 
       
       
        
        float sumList = numList.Sum();
        Console.WriteLine($"The sum is: {sumList}");
        Console.WriteLine($"The average is: {sumList / numList.Count}");
        Console.WriteLine($"The largest number is: {numList.Max()}");
        List<int> onlyPositive = numList.Where(x => x > 0).ToList();
        Console.WriteLine($"The smallest positive number is: {onlyPositive.Min()}");
        Console.WriteLine($"The sorted list is: {string.Join(", ", numList.OrderBy(x => x))}");
        
        
        
        
       
        
    }
}