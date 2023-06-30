namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }
        public Element waekness { get; set; }
        public List<Skill> skills { get; set; }
        public ConsoleMon(int health, int energy, string name, Element waekness, List<Skill> skills)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;
            this.waekness = waekness;
            this.skills = skills;
        }

        internal void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}