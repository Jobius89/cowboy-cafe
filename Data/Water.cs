﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for the Water Drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Whether or not to add a lemon
        /// </summary>
        public bool Lemon = false;

        /// <summary>
        /// Whether or not to add ice
        /// </summary>
        public bool Ice = true;
        
        /// <summary>
        /// The price of the Drink
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// The Calories of the Drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Lemon) instructions.Add("Add Lemon");
                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// String Representation for the food item
        /// </summary>
        /// <returns>string of food item</returns>
        public override string ToString()
        {
            return this.Size + " Water";
        }
    }
}
