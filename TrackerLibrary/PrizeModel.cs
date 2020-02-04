using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the prize that winner gets.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents a place in the ranking.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the place in the ranking.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount (in money) of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents a Prize Percentage depending on PrizeAmount.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
