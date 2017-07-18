using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 13 2017
 Description: SuperHero class that inherits from SuperHuman class
 Version: 0.1- 
 */
namespace Week10
{
    /// <summary>
    /// This is the superHero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        //Private Instance Variables
        private int _karma;
        //Public Properties
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }
        //Constructors
        /// <summary>
        /// This is the main constructor for the superhero class
        /// It takes one argument: name(string) and karma(int)
        /// </summary>
        /// <param name="name"></param>
        /// /// <param name="karma"></param>
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }
        //Private Methods
        //Public Methods
    }
}