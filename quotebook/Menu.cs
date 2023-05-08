public class Menu
{
  private Board _board;
  public Menu(Board board)
  {
    _board = board;
  }

  public void Display()
  {
    string response = "";
    string[] options = {"A", "S", "F", "R", "Q"};

    while(response!= "Q")
    {
      while(options.Contains(response) == false)
      {
        Console.Write("[A]dd a quote:\n[S]how all quotes: \n[F]ind quotes by author: \n[R]andom quote: \n[Q]uit: \n\n What would you like to do? ");
        response = Console.ReadLine() ?? String.Empty;
        response = response.ToUpper();
      }
      switch(response)
      {
       case "Q":
        Console.WriteLine("Goodbye!");
        break;
       case "A":
        Console.Write("Add a quote: ");
        string quote = Console.ReadLine() ?? String.Empty;
        Console.Write("Who said it? ");
        string author = Console.ReadLine() ?? String.Empty;
        Console.Write("What is the source? ");
        string source = Console.ReadLine() ?? String.Empty;
        Console.Write("What is the url? ");
        string url = Console.ReadLine() ?? String.Empty;

        _board.AddQuote(new Quote(author, quote, new Source(source, url)));
        break;
        case "S":
        _board.ShowQuotes();
        break;
        case "F":
        Console.Write("Enter Author Name:");
        string name = Console.ReadLine() ?? String.Empty;
        _board.FindQuotesByAuthor(name);
        break;
        case "R":
        _board.GetRandomQuote();
        break;


      }
      response = "";
    }
  }
}