public class Checklist : GoalStructure
{
  private int _bonusPoints;
  private int _goalFrequency;
  private int _timesCompleted; // How many times the goals has been completed for bonus points
  private string _goalType = "Checklist";

public Checklist(){

}

public Checklist(string nameGoal, string descriptionGoal, int pointsGoal, bool isChecked, int bonusPoints, int goalFrequency){
  _nameGoal = nameGoal;
  _descriptionGoal = descriptionGoal;
  _pointsGoal = pointsGoal;
  _isChecked = isChecked;
  _bonusPoints = bonusPoints;
  _goalFrequency = goalFrequency;
}
  public override void UserInputPointsGoal()
  {
    Console.WriteLine($"How many points is your goal worth?");
    _pointsGoal = int.Parse(Console.ReadLine() ?? String.Empty);
    Console.WriteLine($"How many times does this goal repeat until a bonus?");
    _goalFrequency = int.Parse(Console.ReadLine() ?? String.Empty);
    Console.WriteLine($"What is the bonus amount?");
    _bonusPoints = int.Parse(Console.ReadLine() ?? String.Empty);
    

    
  }
  public override string StringifyGoal()
{
  return $"[ ] {_nameGoal} {_pointsGoal} ";

}

public override string FormatGoal()
{
  return $"{_goalType},{_nameGoal},{_descriptionGoal},{_pointsGoal},{_bonusPoints},{_goalFrequency} {_isChecked}";
}


}