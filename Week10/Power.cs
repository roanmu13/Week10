using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 11 2017
 Description: Created power class
 Version: 0.2- Overloaded the < and > operators for the power class
 */
namespace Week10
{/// <summary>
/// this is the power class which will be used as a data type
/// </summary>
/// 
   //struct can not be inherited from(only public or private)
   //struct can not have empty default constructor

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

        //public overloadedoperators
        //when using operators, always static.need to do both greater than and less than
        /// <summary>
        /// This method overloads the > for use with the power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>returns true if lhs.rank is > rhs.rank</returns>
        public static bool operator >(Power lhs, Power rhs)
        {
            return (lhs.Rank > rhs.Rank);
        }
        /// <summary>
        /// This method overloads the < for use with the power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>returns true if lhs.rank is < rhs.rank</returns>
        public static bool operator <(Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank);
        }

    }
}