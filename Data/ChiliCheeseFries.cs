﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    ///  a class representing the Chili Cheese Fries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;

                    case Size.Medium:
                        return 2.99;

                    case Size.Large:
                        return 3.99;

                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The Calories of the Side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;

                    case Size.Medium:
                        return 524;

                    case Size.Large:
                        return 610;

                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// String Representation for the food item
        /// </summary>
        /// <returns>string of food item</returns>
        public override string ToString()
        {
            return this.Size + " Chili Cheese Fries";
        }
    }
}
