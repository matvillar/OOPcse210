public class WritingAssignment : Assignment
{
private string _title;

public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
{
  _title = title;
}

public string GetWritingInformation()
{
 string _studentName = GetStudentName();
  string _topic = GetTopic();
  return $"Student {_studentName} has been assigned to topic {_topic} and the title is {_title}";
}
}