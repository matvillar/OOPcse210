public class Word
{
private string _word;
private bool _isHidden;

public Word(string word)
{
_word = word;
_isHidden = false;
}

public void Hide()
{
_isHidden = true;

}
}
