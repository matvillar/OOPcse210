public class Entry
{
    public Prompt _prompt = new Prompt();
    public string _response = "";
    public DateTime _date = DateTime.Now;
     public string randomPrompt;

    public Entry()
    {
        randomPrompt = _prompt.GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        _response = Console.ReadLine() ?? string.Empty;
        _date = DateTime.Now;
               
    }

    public string Stringify()
    {
        return $"---------------------------------- \n{_date} \n{randomPrompt} \n{_response} \n---------------------------------- \n";
    }
}