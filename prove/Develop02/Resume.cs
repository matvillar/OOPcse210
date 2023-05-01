public class Resume
{
  public string _firstName;
  public string _lastName;

  public void DisplayResumeDetails(){
    Console.WriteLine($"Name: {_firstName} {_lastName}");
    Console.WriteLine($"Jobs:");
    
  }
}