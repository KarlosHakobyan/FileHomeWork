using System.IO;

internal partial class Program
{

    private static void Main(string[] args)
    {
        string path = "HomeWork";
        string fileName = Path.Combine(path,"FileHomeWork.txt");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        if (!File.Exists(fileName))
        {
            using (FileStream f = File.Create(fileName))
            {           
            }
        }

        List<Student> students = new List<Student>
        {
            new Student ("Aghas",20,155,"NPUA"),
            new Student("Mari", 19, 158, "YSU")
        };
            
        List<Employee> employees = new List<Employee>
        {
            new Employee("Eva", 30, 500000, "Softconstruct"),
            new Employee("Norik", 35, 600000, "Picsart")
        };

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Students:");
            foreach (var student in students)
            {
                writer.WriteLine(student.ToString());
            }

            writer.WriteLine("\nEmployees:");
            foreach (var employee in employees)
            {
                writer.WriteLine(employee.ToString());
            }
        }
        Console.WriteLine($"Data saved to {fileName}");
    }
}