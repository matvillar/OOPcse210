// See https://aka.ms/new-console-template for more information
using System;


    class Program
    {
        static void Main(string[] args)
        {
        
        Journal journal = new Journal();
        Menu menu = new Menu(journal);
        menu.DisplayMenu();
          
        }
    }
