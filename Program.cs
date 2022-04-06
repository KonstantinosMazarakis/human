using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
        Human kostas = new Human("Kostas");
        Human Brandon = new Human("Brandon");

        kostas.Attack(Brandon);
        }
    }
}
