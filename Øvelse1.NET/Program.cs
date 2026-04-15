using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;
string sti = " C:\\Users\\jonas\\Documents";



Console.WriteLine("Hvad ord skal der søges efter");
string Input = Console.ReadLine();
Console.WriteLine("Angiv en text");
string Text = Console.ReadLine();
Console.WriteLine(Class.Count(Input, Text));
int occurences = Class.Count(Input, Text);
bool? result = Class.EvaluateCount(occurences);

if (result == null) 
{
    Console.WriteLine("det søgte ord findes ikke i teksten");
}
else if (result == false) 
{
    Console.WriteLine($"ordet '{Input}' findes {occurences} gange i teksten");
}
else if (result == true)
{
    Console.WriteLine($"ordet '{Input}' findes {occurences} gange i teksten, hvilket er 10 eller flere gange");
}
else if(Input == null)
{
    Console.WriteLine("Du skal indtaste et ord at søge efter");
}
else
{
    
}
string writeText = occurences.ToString(); 
File.WriteAllText("C:\\Users\\jonas\\Documents\\filename.txt", writeText); 

//string readText = File.ReadAllText("filename.txt");  
//Console.WriteLine(readText); 
