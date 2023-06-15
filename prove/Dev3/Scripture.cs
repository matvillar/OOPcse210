public class Scripture
{
  private List<Word> _words = new List<Word>();
  private Reference _reference;
  private string _userInputScripture;
  public Scripture(Reference reference)
  {
 _reference = reference;
 Console.WriteLine("What's the scripture?");
  _userInputScripture = Console.ReadLine();
  string[] userWords = _userInputScripture.Split(' ');
  
  }
   
   public void AddWordsToCreateScripture()
   {
     foreach (string word in userWords)
     {
       Word newWord = new Word(word);
       _words.Add(newWord);
       Console.WriteLine($"Text: {word}");
       
     }
   }
}