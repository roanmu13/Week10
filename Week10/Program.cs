using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 13 2017
 Description: Demo for Lesson 9
 Version: 0.7- Implemented superVillain > and < overloaded operator methods
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

           if(badMan.GetPower("High Jumps") > badMan.GetPower("Fire Burst"))
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
