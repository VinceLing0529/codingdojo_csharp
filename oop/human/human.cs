
namespace human
{
    class Human
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        private int health;
        public int gethealth{get{return health;}}
        public Human(string name)
        {
            Name = name;
            Strength=3;
            Intelligence=3;
            Dexterity =3;
            health =100;
        }
        public Human(string name,int strength,int intelligence, int dexterity,int Health)
        {
            Name = name;
            Strength=strength;
            Intelligence=intelligence;
            Dexterity =dexterity;
            health =Health;
        }
        public int Attack(Human target)
        {
            target.health -= 5*Strength;
            return target.health;
        } 

    }
}