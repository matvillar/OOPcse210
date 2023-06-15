
public class Scripture
{
  private Reference _reference;
  private Word _text;

public Scripture (Reference reference, Word text)
{
  _reference = reference;
  _text = text;
}


public void DisplayScripture()
{
  _text.ShowWord();
 
}
public void HideWord()
{
  _text.AddHiddenWord();

}



}