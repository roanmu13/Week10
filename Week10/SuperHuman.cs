using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 11 2017
 Description: Super Human class that extends abstract human class
 Version: 0.8- Added private _getPowerIndex method
 */
namespace Week10
{
    /// <summary>
    /// This is superHuman class
    /// </summary>
    public class SuperHuman : Human
    {
        //Private instance variable(fields)
        private List<Power> _powers;

        //public properties
        public List<Power> Powers
        {
            get
            {
                return this._powers;//this returns a reference
            }
        }

        //constructors
        /// <summary>
        /// main constructor for super human class. It takes one argument: name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name) : base(name)
        {
            this._initialize();
        }
        //private methods
        /// <summary>
        /// this method initializaes, instantiates and assigns values to class properties
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();//creates an empty list
        }

        /// <summary>
        /// This private method returns the index power of the power name in the power list
        /// If not found, it returns -1
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns the index of the power in the power list by name</returns>
        private int _getPowerIndex(string name)
        {
            int index = 0;
            foreach(Power power in this.Powers)
            {
                if (name.Equals(power.Name)) 
                break;
            }
            index++;
            if(this.Powers.Count == index)
            {
                index = -1;//this means we did not find the power in the list
            }
            return index;
        }

        //public methods
        /// <summary>
        /// method ass a power to the powe list
        /// It take two parameters: name(string), rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// This method displays each of the powers stored in the powers list
        /// </summary>
        public void DisplayPowers()
        {
            foreach (var power in Powers)
            {
                Console.WriteLine("Power: " + power.Name + "Rank: " + power.Rank);
            }
        }
        /// <summary>
        /// The ToString method overrides the built-in object.ToString method. 
        /// It outputs a string that displays the superhuman's name and thier power list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "*****************************************************\n";
            outputString += "Super Human Name: " + this.Name + "\n";
            outputString += "*****************************************************\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n";
            }
            // outputString += "*****************************************************\n";
            return outputString;

        }
        /// <summary>
        /// This method overrides the human abstract superclass's DisplaySkills method
        /// This method will display a list of skills to the console
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not implemented");
        }
    }
}