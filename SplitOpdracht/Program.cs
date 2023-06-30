using System.Runtime.InteropServices;

namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllText("stringsplit.txt").Split(":");

            string[] cijfersPerVak = content[1].Split(",");

            foreach (var cijfer in cijfersPerVak)
            {
                Console.WriteLine(cijfersPerVak);
            }
        }
    }
}