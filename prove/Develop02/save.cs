using System; 

using System.IO; 

public class Save 
{

public List<string> mightSave = new List<string>() {}; 

public void saveFile() 
{
Console.WriteLine("Enter FileName: "); 
string fileName = Console.ReadLine(); 

using (StreamWriter outputFile = new StreamWriter(fileName)){
    foreach (string part in mightSave) {
        outputFile.WriteLine(part); 
    }
}
}

public void display() {
    foreach(string part in mightSave) {
        Console.WriteLine(part);
    }
}

}