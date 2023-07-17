public abstract class  GoalStructure  // Utility class
{
  protected string _nameGoal;
  protected string _descriptionGoal;
  protected int _pointsGoal;
  protected bool _isChecked = false;

  // protected int _totalPoints = 0;


 

 public void UserInputNameGoal(){
    Console.WriteLine($"Whats the name of your goal?");
  _nameGoal = Console.ReadLine() ?? String.Empty;

 }
 

  public  void UserInputDescriptionGoal(){

    Console.WriteLine($"Whats the description of your goal?");
    _descriptionGoal = Console.ReadLine() ?? String.Empty;

  }
  
  //  public  int TotalPoints(){
  //   return _totalPoints;
  //  }

 
public abstract void UserInputPointsGoal();

  // Console.WriteLine($"How many points is your goal worth?");
  // _pointsGoal = int.Parse(Console.ReadLine() ?? String.Empty);
  

  // return _pointsGoal;

public void CheckItDone()
{
   _isChecked = true;
}

public abstract string StringifyGoal();

public abstract string FormatGoal();


}