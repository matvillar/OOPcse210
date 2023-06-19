public class MathAssignment : Assignment
{
private string _textBookSection = "Chapter 3";

private string _problems;


public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
{
    _textBookSection = textBookSection;
    _problems = problems;
}

public string GetHomeworkList()
{
  return $"Section {_textBookSection} has {_problems} problems."
  ;
}
}