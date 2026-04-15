using System.ComponentModel.Design;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

string folder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

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
    string filePath = Path.Combine(folder, "log.txt");
    string message = Filesave.Save(filePath, occurences.ToString());
    Console.WriteLine($"filen er gemt i {filePath}");
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

