using System;

namespace ConsoleMonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Element Fire = Element.Fire;

            ConsoleMon caster = new ConsoleMon(100, 50, "Charizard", Element.Water);
            ConsoleMon target = new ConsoleMon(100, 50, "Chimchar", Element.Water);

            Skill BurningAttack = new Skill(20, 50, "Burning Attack", Fire);

            BurningAttack.UseOn(target, caster);
            */

            /*
            static void TestFactoryFunctions()
            {
                Console.WriteLine("TestFactoryFunctions");
                ConsoleMonFactory factory = new ConsoleMonFactory();
                factory.Load("monsterdata.txt");
                factory.LoadJson("monsterdata.json");
            }

            TestFactoryFunctions();
            */

            static void TestConstructors()
            {
                Console.WriteLine("TestConstructors");
                ConsoleMon mon = new ConsoleMon(200, 200, "ConsoleColorMon", Element.Earth);

                Console.WriteLine(mon.energy == 200);
                Console.WriteLine(mon.name == "ConsoleColorMon");
                Console.WriteLine(mon.health == 200);
                Console.WriteLine(mon.weakness == Element.Earth);

            }

            TestConstructors();
        }
    }
}