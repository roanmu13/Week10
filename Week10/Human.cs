using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 11 2017
 Description: Abstract Human Class
 Version: 0.2- Added Abstract method DisplaySkills
 */
//use these comments for assignment 4
namespace Week10
{
    /// <summary>
    /// Abstract Human Class; abstract says can not create instance of type human
    /// </summary>
    public abstract class Human
    {
        //Private instance variables(fields)

        private string _name;


        //Public Properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        //Constructors--------------------------------
        /// <summary>
        /// this is the main constructor for the human class; it takes one argument: name(string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }

        //Private Methods

        //Public Methods
        public abstract void DisplaySkills();

        public abstract void Trains();
    }
}