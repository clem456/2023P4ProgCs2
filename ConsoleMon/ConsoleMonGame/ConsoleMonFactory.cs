using System;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string dataFile)
        {
            string[] data = File.ReadAllLines(dataFile);

            foreach (string line in data)
            {
                Console.WriteLine(line);
            }
        }
    }
}