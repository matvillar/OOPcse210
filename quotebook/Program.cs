Source source = new Source("None Were with Him", "https://www.churchofjesuschrist.org/study/general-conference/2009/04/none-were-with-him?lang=eng");



Quote holland = new Quote("Jeffrey R. Holland", "Because Jesus walked such a long, lonely path utterly alone, we do not have to do so.", source);

// Console.WriteLine(holland.GetQuote());
Board _board = new Board();
_board.AddQuote(holland);
_board.AddQuote(new Quote("Paul", "He preached the death, resurrection, and lordship of Jesus Christ, and he proclaimed that faith in Jesus guarantees a share in his life.", new Source("2 Timothy 1:7")));
_board.AddQuote(new Quote("Elder D. Todd Christofferson", "The Savior’s Atonement is not just for those who need to repent; it is also for those who need to forgive.", new Source("The Divine Gift of Forgiveness", "https://www.churchofjesuschrist.org/study/general-conference/2015/10/why-the-church?lang=eng")));
Board quoteBoard = new Board();

// _board.GetRandomQuote();

Menu menu = new Menu(_board);
menu.Display();