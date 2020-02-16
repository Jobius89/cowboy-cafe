using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {

        /// <summary>
        /// Whether or not to add ice
        /// </summary>
        public bool Ice = true;

        /// <summary>
        /// Whether or not there is a lemon
        /// </summary>
        public bool Lemon = false;

        /// <summary>
        /// Whether or not it is a sweet tea
        /// </summary>
        public bool Sweet = true;

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
                        return 1.00;

                    case Size.Medium:
                        return 1.50;

                    case Size.Large:
                        return 2.00;

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
                if( Sweet == true){
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;

                        case Size.Medium:
                            return 22;

                        case Size.Large:
                            return 36;

                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;

                        case Size.Medium:
                            return 11;

                        case Size.Large:
                            return 18;

                        default:
                            throw new NotImplementedException();
                    }
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
                if(Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}
