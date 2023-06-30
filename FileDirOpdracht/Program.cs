namespace FileDirOpdracht;
using System.IO;
using System.Xml.XPath;

internal class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(@"C:\Users\clemc\OneDrive\Documenten\Ma\Lj1\Prog\Periode4\2023P4ProgCs2");

        DirectoryInfo[] dirInfo = dir.GetDirectories();

        string indicator = "";
        
        void getDir(DirectoryInfo dir)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(indicator + dir.Name);

            indicator += "---- ";

            foreach(var child in dir.GetDirectories())
            {
                if (child.GetDirectories().Length > 0)
                {
                    getDir(child);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(indicator + dir.Name);
                }
            }
        }

        foreach (var child in dirInfo)
        {
            indicator = "";
            getDir(child);
        }
    }
}