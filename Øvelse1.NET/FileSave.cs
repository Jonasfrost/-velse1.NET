using System;
public class Filesave
{
    public static string Save(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
        return "Fil gemt i din user folder.";
    }

    public static string Save(string content)
    {
        string projectFolder = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;

        string filePath = Path.Combine(projectFolder, "log.txt");

        File.WriteAllText(filePath, content);

        return "Fil gemt i din konsol app projekt.";
    }
}
