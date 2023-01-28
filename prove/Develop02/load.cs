using System; 

using System.IO; 

public class Load
{
    public void ReadFile(){
        Console.WriteLine("Enter Filename: "); 
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName); 

        foreach (string line in lines) {
            string[] parts = line.Split(","); 
            Console.WriteLine(parts);
        }

    }

}