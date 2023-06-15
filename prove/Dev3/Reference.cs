public class Reference
{
  private string _book = "";
  private int _chapter;
  private int _initVerse;
  private int _finalVerse;


 public Reference(string book, int chapter, int initVerse, int finalVerse)
 {
   _book = book;
   _chapter = chapter;
   _initVerse = initVerse;
   _finalVerse = finalVerse;
 }

public string StrignifyRef()
{
  return $" {_book} {_chapter}:{_initVerse}-{_finalVerse}";
}
}