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

            static void TestFactoryFunctions()
            {
                Console.WriteLine("TestFactoryFunctions");
                ConsoleMonFactory factory = new ConsoleMonFactory();
                factory.Load("monsterdata.txt");
            }

            TestFactoryFunctions();
        }
    }
}