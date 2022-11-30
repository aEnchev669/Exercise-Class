using System;

namespace _3.Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {

            int totalPower = 0;
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                if (type == "Druid")
                {
                    Druid druid = new Druid(name, 80);
                    Console.WriteLine(druid.CastAbility(type, name, 80));
                    totalPower += 80;
                }
                else if (type == "Paladin")
                {
                    Paladin paladin = new Paladin(name, 100);
                    Console.WriteLine(paladin.CastAbility(type, name, 100));
                    totalPower += 100;
                }
                else if (type == "Rogue")
                {
                    Rogue rogue = new Rogue(name, 80);
                    Console.WriteLine(rogue.CastAbility(type, name, 80));
                    totalPower += 80;
                }
                else if (type == "Warrior")
                {
                    Warrior warrior = new Warrior(name, 100);
                    Console.WriteLine(warrior.CastAbility(type, name, 100));
                    totalPower += 100;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                }
            }
            int bossHealt = int.Parse(Console.ReadLine());

            if (totalPower >= bossHealt)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }

        }
    }
}
