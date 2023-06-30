namespace ConsoleMonGame
{
    internal class Skill
    {
        public int damage { get; set; }
        public int energyCost { get; set; }
        public string name { get; set; }
        public Element element { get; set; }

        public Skill(int damage, int energyCost, string name, Element element)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
            this.element = element;
        }

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(this.damage);
            caster.DepleteEnergy(this.energyCost);


            // for test
            Console.WriteLine($"Before: {caster.name} energy is {caster.energy} and health is {caster.health}");
            Console.WriteLine($"Before: {target.name} energy is {target.energy} and health is {target.health}");

            Console.WriteLine($"{caster.name} used {this.name} on {target.name}");

            Console.WriteLine($"After: {caster.name} energy is {caster.energy} and health is {caster.health}");
            Console.WriteLine($"After: {target.name} energy is {target.energy} and health is {target.health}");
        }
    }
}