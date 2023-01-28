using System;
using System.IO; 

static void Main(string[] args)
{

    Console.WriteLine("Welcome To the Journal App"); 

    int number = 0;

    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString(); 
    
    while (number != 5) {
        Console.WriteLine("Please Select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        string choice = Console.ReadLine();

        number = int.Parse(choice); 

        if(number == 1) {
            
            Prompt prompt = new Prompt();
            string randomPrompt = prompt.PrintRandomPrompt(); 
            string response = Console.ReadLine(); 

            Save save = new Save(); 
            save.mightSave.Add(dateText); 
            save.mightSave.Add(randomPrompt);
            save.mightSave.Add(response); 
            
        }

        else if(number == 2) {
            Save save = new Save(); 
            save.display(); 
            
        }

        else if(number == 3) {
            Load Load = new Load(); 
            Load.ReadFile(); 
            
        }

        else if(number == 4) {
            Save save = new Save(); 
            save.saveFile(); 
            
        }

        else
        {
            break; 
        }
    }

}

Main(null);