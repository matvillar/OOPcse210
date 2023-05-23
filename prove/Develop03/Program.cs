using System;


class Program
{
    static void Main(string[] args)
    {
        // Scripture scripture1 = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        // Scripture scripture2 = new Scripture("John 3:17", "For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");

Scripture scripture = new Scripture();
Word word1 = new Word();
scripture.addWordToScripture(word1);
scripture.DisplayScripture();

       

    //
    //     string userWord = Console.ReadLine();
    //     word1.WordGetSet = userWord;



    
       
        
        
        // Console.WriteLine(word1.HideWord());
        // Console.WriteLine(word1.ShowWord());
    
   

    }
}