using System.Text;
using System.Text.Unicode;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("leesdezefile.txt");

            File.WriteAllText(@"mijnnieuwefile.txt", "hey!");

            foreach (string line in content)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine(File.ReadAllText(@"mijnnieuwefile.txt"));

            string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "output");
            Directory.CreateDirectory(outputDirectory);
            string outputPath = Path.Combine(outputDirectory, "mijnnieuwefile.txt");
            File.WriteAllText(outputPath, "hier ben ik");

            Console.WriteLine(File.ReadAllText(@"output/mijnnieuwefile.txt"));
        }
    }
}