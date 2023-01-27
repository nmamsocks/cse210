using System; 

public class Job 
{
    public string _sbcompany = ""; 
    public string _sbjobtitle = "";

    public int _sbStart = 0;

    public int _sbEnd = 0;

    public void Display(){
        Console.WriteLine($"{_sbjobtitle}, ({_sbcompany}) {_sbStart} {_sbEnd}");
    }
}