using System;

namespace human
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
        }
    public Human(string n)
    {
        this.Name = n;
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
    
    public int Attack(Human target)
    {
        target.health = target.Health - (5 * this.Strength);
        Console.WriteLine($"Targets Health: {target.Health}");
        return target.Health;
    }


    }
}
