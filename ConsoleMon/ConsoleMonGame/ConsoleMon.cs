namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;
        internal Element waekness;
        private List<Skill> skills = new List<Skill>();
        public ConsoleMon(int health, int energy, string name, Element waekness)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;
            this.waekness = waekness;
        }

        internal void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        internal void DelpleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}