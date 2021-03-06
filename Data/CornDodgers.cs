﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    ///  a class representing the CornDodgers side
    /// </summary>
    public class CornDodgers : Side
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
                        return 1.59;

                    case Size.Medium:
                        return 1.79;

                    case Size.Large:
                        return 1.99;

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
                        return 512;

                    case Size.Medium:
                        return 685;

                    case Size.Large:
                        return 717;

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
            return this.Size + " Corn Dodgers";
        }
    }
}
