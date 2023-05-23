using System.Text;
public class Word
{
  private string _word;
  private bool _isHidden = false;
  
  string _hiddenWord;

public Word()

  { 
   
     WordGetSet = _word;
     Console.WriteLine("Whats the word you want to add to the scripture?");
     WordGetSet = Console.ReadLine() ?? string.Empty;
     Console.WriteLine($"typeoff: {WordGetSet}");
     
   
  }
 public string HideWord()
{
  _isHidden = true;
  if (_isHidden == true)
  {
     StringBuilder builder = new StringBuilder();
        foreach (char c in WordGetSet)
        {
            if (char.IsLetter(c))
            {
                builder.Append('_');
            }
            else
            {
                builder.Append(c);
            }
        }
        return builder.ToString();
    // _hiddenWord = new string('_', WordGetSet.Length);
  }
  return _hiddenWord;
  
}
public string ShowWord()
{
 _isHidden = false;
  if (_isHidden == false)
  {
    _hiddenWord = WordGetSet;
  }
  return _hiddenWord;
}
public string WordGetSet
  {
    get { return _word; }
    set { _word = value; }
  }

}