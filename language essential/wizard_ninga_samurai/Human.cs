using System;
using System.Collections.Generic;
using System.Linq;

namespace wizard_ninga_samurai
{
    class Human
    {
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
     
    public int Health
    {
        get { return health; }
        set { health = Health; }
    }
     
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }
     
    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        health = hp;
    }
     
    // Build Attack method
    public virtual int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.health;
    }
    }

    class Wizard : Human
    {
        public Wizard(string name): base(name)
            {
                Name = name;
                Intelligence = 25;
                Health = 50;
            }
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 3;
            target.Health -= dmg;
            this.Health +=  dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;            
        }
        public int Heal(Human target)
        {
            int heal = 10*Intelligence;
            target.Health+= heal;
            Console.WriteLine($"{Name} healed {target.Name} for {heal} hp!");
            return target.Health;
        }
    }
        class Ninja : Human
    {
        public Ninja(string name): base(name)
            {
                Name = name;
                Dexterity = 175;
            }
        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            Random rand = new Random();
            if(rand.Next(0,6)==0)
            {
                dmg+=10;
            }
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;            
        }
        public int Steal(Human target)
        {
            this.Health +=5;
            target.Health-= 5;
            Console.WriteLine($"{Name} Stealed {target.Name} for 5 hp!");
            return target.Health;
        }
    }
            class Samurai : Human
    {
        public Samurai(string name): base(name)
            {
                Name = name;
                Health = 200;
            }
        public override int Attack(Human target)
        {
            int dmg = Strength*3;
            if(target.Health<=50)
            {
                Console.WriteLine($"{Name} attacked {target.Name} for {target.Health} damage!");
                target.Health=0;
            }
            else
            {
                target.Health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");

            }
            
            return target.Health;            
        }
        public int Meditate()
        {
            this.Health =200;
            Console.WriteLine($"{Name} Meditated {this.Name} for {this.Health} hp!");
            return this.Health;
        }
    }
}