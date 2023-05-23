public class Journal
{

   public List<Entry> _entries = new List<Entry>();
  private string _fileName = "";

 public void AddEntry(Entry newEntry)
 {  
     
     _entries.Add(newEntry);

 } 

 
 public void displayEntries()
 {
   foreach (Entry entry in _entries)
   {
    
     Console.WriteLine(entry.Stringify());
   }
 }

 public static void saveEntryToFile(List<Entry> entries)
 {
   Console.WriteLine($"What is the file name?");
    string _fileName = Console.ReadLine() ?? string.Empty;
    if(_fileName == ""){
      _fileName = "default";
    }
    string _filePath = $"./savedFiles/{_fileName.ToLower().Trim()}.txt";

    using (StreamWriter writer = new StreamWriter(_filePath))
    {
      foreach (Entry entry in entries)
      {
        writer.WriteLine(entry.Stringify());
      }
    }
   
 }
 public static List<Entry> loadEntriesFromFile()
 {
  List<Entry> _entries = new List<Entry>();

  Console.WriteLine($"What is the file name?");
  string _fileName = Console.ReadLine() ?? string.Empty;
 if(_fileName == ""){
   _fileName = "default";}

  string[] lines = System.IO.File.ReadAllLines($"./savedFiles/{_fileName.ToLower().Trim()}.txt");

  foreach (string line in lines)
  {
     Console.WriteLine($"{line}");
     
  }

 
 return _entries;
 }
}