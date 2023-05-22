namespace FileDirOpdracht;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(@"C:\Users\clemc\OneDrive\Documenten\Ma\Lj1\Prog\Periode4\2023P4ProgCs2");

        FileInfo[] fileInfo = dir.GetFiles();
        DirectoryInfo[] dirInfo = dir.GetDirectories();

        foreach (var file in fileInfo)
        {
            Console.WriteLine(file.Name);
        }

        foreach (var newDir in dirInfo) 
        {
            Console.WriteLine(newDir.Name);
        }
    }
}