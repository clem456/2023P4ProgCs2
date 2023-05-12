namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;
        private List<Skill> skills = new List<Skill>();
        public ConsoleMon(int health, int energy, string name)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;
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