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

        internal List<ConsoleMon> LoadJson(string dataFile)
        {
            string json = File.ReadAllText(dataFile);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);

            return templates;
        }

        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {
            ConsoleMon copyResult = new ConsoleMon(copyFrom.health, copyFrom.energy, copyFrom.name, copyFrom.weakness);
            copyResult.skills = new List<Skill>();

            foreach(Skill skill in copyFrom.skills)
            {
                copyResult.skills.Add(skill);
            }

            return copyResult;
        }

        internal Skill CopySkill(Skill copyFrom)
        {
            Skill copyResult = new Skill(copyFrom.damage, copyFrom.energyCost, copyFrom.name, copyFrom.element);

            return copyResult;
        }
    }
}