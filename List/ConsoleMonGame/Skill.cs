namespace ConsoleMonGame
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;

        public Skill(int damage, int energyCost, string name)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
        }

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(this.damage);
            caster.DelpleteEnergy(this.energyCost);


            // for test
            Console.WriteLine($"Before: {caster.name} energy is {caster.energy} and health is {caster.health}");
            Console.WriteLine($"Before: {target.name} energy is {target.energy} and health is {target.health}");

            Console.WriteLine($"{caster.name} used {this.name} on {target.name}");

            Console.WriteLine($"After: {caster.name} energy is {caster.energy} and health is {caster.health}");
            Console.WriteLine($"After: {target.name} energy is {target.energy} and health is {target.health}");
        }
    }
}