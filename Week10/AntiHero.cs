using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Rosa Munguia
 * Date: July 20 2017
 * Description: This is the anit-hero class
 * it extends the superhuman class and implements the IHasKarma and IHasMalice interfaces
 * Version 0.1: created the anithero class
 */
namespace Week10
{
    public class AntiHero : SuperHuman, IHasKarma, IHasMalice
    {
        //PRIVATE INSTANCE VARIABLES
        private int _karma;
        private int _malice;
        //PUBLIC PROPERTIES
        public int Karma { get
            {
                return this._karma;
            }
            set
            {
                this._karma=value;

            }
        }

        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice=value;
            }
        }
       
        /// <summary>
        /// Main constructor for AntiHero class
        /// takes 3 arguments: name(string), karma(int) and malice(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        /// <param name="malice"></param>
        //CONSTRUCTORS
        public AntiHero(string name, int karma, int malice) : base(name)
        {
            this.Karma = karma;
            this.Malice = malice;
        }

        
        //PUBLIC METHODS
        //public override void Trains()
        //{
        //    Console.WriteLine("Not Implemented");
        //}
        //PRIVATE METHODS

    }
}