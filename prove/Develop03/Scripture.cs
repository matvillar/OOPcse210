public class Scripture
{
  // private string _reference;

  public List<Word> _wordsToScripture = new List<Word>();



public void addWordToScripture(Word word1)
{
Console.WriteLine($"Text: {word1}");

  _wordsToScripture.Add(word1);
  
}
public void DisplayScripture()
{

  
  foreach (Word word in _wordsToScripture)
  {
    Console.WriteLine(word.ShowWord());
    Console.WriteLine(word.HideWord());
    
  }
}


  // public Scripture(string reference, string vers)
  // {
  //   Reference = reference;
  //   Vers = vers;

  // }

  // public string StringifyScripture()
  // {
  //   return $"{Reference}, {Vers}";
  // }

  // public string Reference
  // {
  //   get { return _reference; }
  //   set { _reference = value; }
  // }

  // public string Vers
  // {
  //   get { return _vers; }
  //   set { _vers = value; }
  // }
}