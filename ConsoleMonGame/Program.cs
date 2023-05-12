using System;

namespace ConsoleMonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleMon caster = new ConsoleMon(100, 50, "Charizard");
            ConsoleMon target = new ConsoleMon(100, 50, "Chimchar");

            Skill BurningAttack = new Skill(20, 50, "Burning Attack");

            BurningAttack.UseOn(target, caster);
        }
    }
}