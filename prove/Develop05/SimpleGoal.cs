public class SimpleGoal : GoalStructure
{


string _goalType = "SimpleGoal";

public SimpleGoal()
{

}
public SimpleGoal(string nameGoal, string descriptionGoal, int pointsGoal, bool isChecked)
{
  _nameGoal = nameGoal;
  _descriptionGoal = descriptionGoal;
  _pointsGoal = pointsGoal;
  _isChecked = isChecked;
}

public override void UserInputPointsGoal(){
  Console.WriteLine($"How many points is your goal worth?");
  _pointsGoal = int.Parse(Console.ReadLine() ?? String.Empty);
  
}

public override string StringifyGoal()
{
  return $"[ ] {_nameGoal} {_pointsGoal} ";

}

public override string FormatGoal()
{
  return $"{_goalType},{_nameGoal},{_descriptionGoal},{_pointsGoal},{_isChecked}";
}

}