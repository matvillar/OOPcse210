using System;
using System.Text;

public class Word
{
    private string _word;
    // private bool _isHidden = false;
    // private string _hiddenWordString;
    private List<string> wordList = new List<string>();
    private List <string> hiddenWordList = new List<string>();
    
    // private bool allWordsHidden = false;
    
    

    public Word()

    {
        Console.WriteLine("What's the word you want to add to the scripture?");
        _word = Console.ReadLine() ?? string.Empty;

        foreach (string word in _word.Split(' '))
        {
            wordList.Add(word);
        }
    }


    public void ShowWord()
    {
      foreach (string word in wordList)
      {
        Console.Write($"{word} ");
        
      }


  
    }

public void AddHiddenWord()
{
    Random random = new Random();
    int randomWord = random.Next(0, wordList.Count);
    string hiddenWord = wordList[randomWord];
 


 if (hiddenWordList.Contains(hiddenWord))
        {
            // Word is already hidden, choose another word
            AddHiddenWord();
            return;
        }
         hiddenWordList.Add(hiddenWord);
          
    foreach (string word in wordList)
    {

// if word is already hidden, then choose another word


    if(hiddenWordList.Contains(word))
    {
      // replace each letter in word with "_"
      StringBuilder _hiddenWordString = new StringBuilder();
      foreach (char letter in word)
      {
        _hiddenWordString.Append("_");
      }
      Console.Write($"{_hiddenWordString} ");
    }
    else
    {
      Console.Write($"{word} ");
    }
    
    }

    // if (hiddenWordList.Count == wordList.Count)
    // {
    //   allWordsHidden = true;
    // }
 
  }

}
    
    
