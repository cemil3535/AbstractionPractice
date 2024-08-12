// See https://aka.ms/new-console-template for more information

using AbstractionPractice;

public class Program
{
    public static void Main(string[] args)
    {
        // object created 
        ProjectManager manager = new ProjectManager()
        {
            Name = "Hasan",
            Surname = "Cildirmis",
            Department = "ARGE"
        };
        // Duty abstract metod call
        manager.Duty();
    }
}