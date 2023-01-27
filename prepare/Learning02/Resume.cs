using System; 

public class Resume {
    public string _sbname; 

    public List<Job> _sbjobs = new List<Job>(); 

    public void Display() {
        Console.WriteLine($"name: {_sbname}"); 
        Console.WriteLine("jobs: ");

        foreach (Job job in _sbjobs) {
            job.Display(); 
        }
    }
}