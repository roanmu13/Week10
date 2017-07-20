using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 20 2017
 Description: Driver class for project
 Version: 0.6- Implemented antiHero class
 */
namespace Week10
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            superHero.Powers.Add(new Power("Teleporting", 35));
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma points: " + superHero.Karma + "\n");


            SuperVillain badMan = new SuperVillain("Evil Eye", 35);
            badMan.AddPower("Fire Burst", 30);
            badMan.AddPower("High Jumps", 25);
            Console.WriteLine(badMan.ToString());
            Console.WriteLine("Malice points: " + badMan.Malice + "\n");

            AntiHero batMan = new AntiHero("Batman", 20, 20);
            batMan.AddPower("Super Intelligence", 50);
            Console.WriteLine(batMan.ToString());
            Console.WriteLine("Karma points: " + batMan.Karma + "\n");
            Console.WriteLine("Malice points: " + batMan.Malice + "\n");

            Console.WriteLine();
            if (badMan.GetPower("High Jumps") > badMan.GetPower("Fire Burst"))
            {
                Console.WriteLine("High Jumps is more powerful than Fire Burst");
            }
            if (badMan.GetPower("Fire Burst") > badMan.GetPower("High Jumps"))
            {
                Console.WriteLine("Fire Burst is more powerful than High Jumps");
            }
            else
            {
                Console.WriteLine("Fire Burst is weaker than High Jumps");
            }
        }
    }
}
