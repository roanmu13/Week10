using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 18 2017
 Description: Creating superVillain Class
 Version: 0.1- Updated constructor
 */
namespace Week10
{
    /// <summary>
    /// This is supervillain class
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {
        //Private instance variables
        private int _malice;
        //Public Properties
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }
        //Constructors
        /// <summary>
        /// This is the main constructor for SuperVillain class
        /// Takes two parameters- name(string) and malice(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }
    }
}