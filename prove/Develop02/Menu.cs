public class Menu
{
 public Journal _journal;
 


  public Menu(Journal journal)
  {
    _journal = journal;
  }

  public void DisplayMenu(){

    string response = "";
    string[] options = {"1", "2", "3", "4","5"};

    while(response != "5"){

     
        Console.Write("[1] Add New Entry \n[2] Display Journal \n[3] Save Entry \n[4] Load file \n[5] Quit \n\n What would you like to do? ");
        response = Console.ReadLine() ?? String.Empty;
        response = response.ToUpper();
      if(options.Contains(response) == false){
        Console.WriteLine("Please enter a valid option");
      }
      
      switch(response){
     
          case "1":
          Entry _entry = new Entry();
         
          _journal.AddEntry(_entry);
          break;
          case "2":
          if(_journal._entries.Count != 0){
           _journal.displayEntries();
            
          }
          else{
           Console.WriteLine("\n------------ No entries to display ------------ \n\n");
          
          }
          break;
          
          

      }
      
    }
    Console.WriteLine($"Goodbye!");
    
  }
}