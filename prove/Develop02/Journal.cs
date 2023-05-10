public class Journal
{

   public List<string> _entries = new List<string>();
  

 public void AddEntry(string newEntry)
 {  
     
     _entries.Add(newEntry);

 } 

 
 public void displayEntries()
 {
   foreach (string entry in _entries)
   {
    
     Console.WriteLine(entry);
   }
 }
}