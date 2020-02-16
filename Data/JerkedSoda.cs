using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {


        /// <summary>
        /// Whether or not to add ice
        /// </summary>
        public bool Ice = true;

        /// <summary>
        /// Holds which flavor soda is
        /// </summary>
        public SodaFlavor Flavor;

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
                        return 1.59;

                    case Size.Medium:
                        return 2.10;

                    case Size.Large:
                        return 2.59;

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
                        return 110;

                    case Size.Medium:
                        return 146;

                    case Size.Large:
                        return 198;

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

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
    }
}
