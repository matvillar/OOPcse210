public class Journal
{

   public List<Entry> _entries = new List<Entry>();
  

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
}