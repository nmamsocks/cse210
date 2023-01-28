using System; 

public class Prompt 
{

List<String> newPrompt = new List<string>() {
    "Eat Any Good Food Today?",
    "What is the weather like?",
    "Learn anything new in the scriptures?",
    "How was class?",
    "Learn anything cool?"
};


 
public string PrintRandomPrompt()
{
    Random rand = new Random(); 
    int randInt = rand.Next(0, newPrompt.Count); 

    string randomPrompt = newPrompt[randInt];

    Console.WriteLine(randomPrompt); 
    
    return randomPrompt; 

}

}