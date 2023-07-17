 public class Menu
{
 public Board _board = new Board();


  
  public void DisplayMenu(){
    bool quit = false;
    string response = "";
    string[] options = {"1", "2", "3", "4", "5", "6"};

Console.WriteLine($"You have {_board._goalEntry} goals.");

    while(!quit)
    {
        while(options.Contains(response)== false)
      {
        Console.WriteLine(" ");
        
        Console.Write("Menu Options:\n[1] Create New Goal\n[2] List Goals \n[3] Save Goals \n[4] Load Goals \n[5] Record Event \n[6] Quit ");
        response = Console.ReadLine() ?? String.Empty;
      } 
      // Clear the console
      Console.Clear();
      // padre
      switch(response) 
      {
        case "1":
       
       string[] options1 = {"1", "2", "3"};
    string response1 = "";
       if(options1.Contains(response1)== false)
      {
        Console.WriteLine(" ");
        
        Console.Write("[1] Simple Goal\n[2] Eternal Goal \n[3] CheckList Goal \n\n What would you like to do? ");
        response = Console.ReadLine() ?? String.Empty;
      }
      // hijo
      switch(response)
      {
        case "1":
        SimpleGoal simpleGoal = new SimpleGoal();
        simpleGoal.UserInputNameGoal();
        simpleGoal.UserInputDescriptionGoal();
        simpleGoal.UserInputPointsGoal();
        // simpleGoal.TotalPoints();
        _board.AddGoal(simpleGoal);
        break;
        case "2":
        EternalGoal eternalGoal = new EternalGoal();
        eternalGoal.UserInputNameGoal();
        eternalGoal.UserInputDescriptionGoal();
        eternalGoal.UserInputPointsGoal();
        _board.AddGoal(eternalGoal);
        break;
        case "3":
        break;
      }
     response= "";
        DisplayMenu();
        break;
        case "2":
        _board.DisplayGoals();
        DisplayMenu();
        break;
        case "3":
        Board.SaveGoalsToFile(_board._goalEntry);
        DisplayMenu();
        break;
        case "4":
        Board.LoadEntries();
        DisplayMenu();
        break;

      }
    }
     
    response = "";
  }
}