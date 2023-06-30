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

            /*
            static void TestConstructors()
            {
                Console.WriteLine("TestConstructors");
                ConsoleMon mon = new ConsoleMon(200, 200, "ConsoleColorMon", Element.Earth);

                Console.WriteLine(mon.energy == 200);
                Console.WriteLine(mon.name == "ConsoleColorMon");
                Console.WriteLine(mon.health == 200);
                Console.WriteLine(mon.weakness == Element.Earth);

                Skill skill = new Skill(90, 80, "FireBlade", Element.Fire);
                Console.WriteLine(skill.energyCost == 80);
                Console.WriteLine(skill.name == "FireBlade");
                Console.WriteLine(skill.damage == 90);
                Console.WriteLine(skill.element == Element.Fire);
            }

            TestConstructors();
            */

            /*
            static void TestCopySkill()
            {
                Console.WriteLine("TestCopySkill");
                ConsoleMonFactory factory = new ConsoleMonFactory();
                List<ConsoleMon> templates = factory.LoadJson("monsterdata.json");
                Skill copyFrom = templates[0].skills[0];

                Skill copy = factory.CopySkill(copyFrom);
                Console.WriteLine(copy.name == copyFrom.name);
                Console.WriteLine(copy.damage == copyFrom.damage);
                Console.WriteLine(copy.element == copyFrom.element);
                copy.name = "anders";
                Console.WriteLine(copy.name != copyFrom.name);
            }

            TestCopySkill();
            */

            static void TestCopyConsoleMon()
            {
                Console.WriteLine("TestCopyConsoleMon");
                ConsoleMonFactory factory = new ConsoleMonFactory();
                List<ConsoleMon> templates = factory.LoadJson("monsterdata.json");
                ConsoleMon copyFrom = templates[0];

                ConsoleMon copy = factory.CopyConsoleMon(copyFrom);
                Console.WriteLine(copy.name == copyFrom.name);
                Console.WriteLine(copy.health == copyFrom.health);
                Console.WriteLine(copy.skills == copyFrom.skills);
                Console.WriteLine(copy.skills[0] == copyFrom.skills[0]);
                copy.name = "anders";
                copy.skills[0].name = "newskill";
                Console.WriteLine(copy.name != copyFrom.name);
                Console.WriteLine(copy.skills[0].name != copyFrom.skills[0].name);

                // 1ste false komt omdat het 2 verschillende instanties zijn van skill
                // 2de false komt omdat de skills wel gelijk zijn aan elkaar maar er staan != voor
            }

            TestCopyConsoleMon();
        }
    }
}