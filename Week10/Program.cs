using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 13 2017
 Description: Demo for Lesson 9
 Version: 0.6- Added superVillain and powers
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
        }
    }
}
