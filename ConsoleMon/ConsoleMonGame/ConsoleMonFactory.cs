using System;
using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string dataFile)
        {   
            string[] data = File.ReadAllLines(dataFile);

            foreach (string line in data)
            {
                string[] typeSplit = line.Split("|");

                string[] consoleMonData = typeSplit[0].Split(",");

                ConsoleMon dataMon = new ConsoleMon(int.Parse(consoleMonData[2]), int.Parse(consoleMonData[4]), consoleMonData[0], Element.Fire);

                Console.WriteLine(dataMon.name);
            }
        }

        internal void LoadJson(string dataFile)
        {
            string json = File.ReadAllText(dataFile);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);

            Console.WriteLine(templates[0].name);
        }
    }
}