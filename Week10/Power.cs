﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 11 2017
 Description: Created power class
 Version: 0.2- Created for power class
 */
namespace Week10
{/// <summary>
/// this is the power class which will be used as a data type
/// </summary>
    public class Power
    {

        //public properties
        public string Name { get; set; }
        public int Rank { get; set; }
        //constructors
        /// <summary>
        /// This is the main constructor for the power class.
        /// It takes two srguments-name(string), rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Rank"></param>
        public Power(string name, int Rank)
        {
            this.Name = name;
            this.Rank = Rank;
        }

    }
}