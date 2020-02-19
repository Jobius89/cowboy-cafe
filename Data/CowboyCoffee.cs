using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for the Cowboy Coffee Drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Whether or not to hold room for cream
        /// </summary>
        public bool RoomForCream = false;
        
        /// <summary>
        /// Whether or not to add ice
        /// </summary>
        public bool Ice = false;

        /// <summary>
        /// Whether or not coffee is decafinated
        /// </summary>
        public bool Decaf = false;

        /// <summary>
        /// The price of the Drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .60;

                    case Size.Medium:
                        return 1.10;

                    case Size.Large:
                        return 1.60;

                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The Calories of the Drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;

                    case Size.Medium:
                        return 5;

                    case Size.Large:
                        return 7;

                    default:
                        throw new NotImplementedException();
                }
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

                if (Ice) instructions.Add("Add Ice");
                if(RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// String Representation for the food item
        /// </summary>
        /// <returns>string of food item</returns>
        public override string ToString()
        {
            return this.Size + " Cowboy Coffee";
        }
    }
}
