public class Board 
{
 public List<GoalStructure> _goalEntry = new List<GoalStructure>();





public void AddGoal(GoalStructure newGoal)
{
  
  _goalEntry.Add(newGoal);

}

// Sum total points of all goals


public void DisplayGoals()

{
  int i = 1;
  foreach (GoalStructure goal in _goalEntry)
  {
   
    Console.WriteLine($"{i}. {goal.StringifyGoal()}.");
  
    
    i++;
  }
}

public static void SaveGoalsToFile(List<GoalStructure> goalEntry){
   Console.WriteLine($"What is the file name?");
    string _fileName = Console.ReadLine() ?? string.Empty;
    if(_fileName == ""){
      _fileName = "default";
    }
    string _filePath = $"./savedFiles/{_fileName.ToLower().Trim()}.txt";

    using (StreamWriter writer = new StreamWriter(_filePath))
    {
      foreach (GoalStructure goal in goalEntry)
      {
        writer.WriteLine(goal.FormatGoal());
      }
    }

}

public static List<GoalStructure> LoadEntries()
{
  List<GoalStructure> _goalEntry = new List<GoalStructure>();

  Console.WriteLine($"What is the file name?");
  string _fileName = Console.ReadLine() ?? string.Empty;
 if(_fileName == ""){
   _fileName = "default";}

  string[] lines = System.IO.File.ReadAllLines($"./savedFiles/{_fileName.ToLower().Trim()}.txt");

  foreach (string line in lines)
  {
    
    string[] goal = line.Split(',');
    string _goalType = goal[0];
    if (_goalType == "SimpleGoal")
    {
    string _nameGoal = goal[1];
    string _descriptionGoal = goal[2];
    int _pointsGoal = int.Parse(goal[3]);
    bool _isChecked = bool.Parse(goal[4]);
    _goalEntry.Add(new SimpleGoal(_nameGoal, _descriptionGoal, _pointsGoal, _isChecked));
    }
    else if (_goalType == "EternalGoal")
    {
         string _nameGoal = goal[1];
    string _descriptionGoal = goal[2];
    int _pointsGoal = int.Parse(goal[3]);
    bool _isChecked = bool.Parse(goal[4]);
    _goalEntry.Add(new EternalGoal(_nameGoal, _descriptionGoal, _pointsGoal, _isChecked));
    }
    else if (_goalType == "Checklist")
    {
         string _nameGoal = goal[1];
    }
  // display goals

  foreach (GoalStructure goals in _goalEntry)
  {
    Console.WriteLine($"{goals.StringifyGoal()}.");
  
  } 

  
}
return _goalEntry;
}
}