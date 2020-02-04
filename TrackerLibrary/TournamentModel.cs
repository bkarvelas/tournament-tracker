using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the basic model of the application whitch is the Tournament.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Tournament name e.g.: Pink Pong Tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the Entry Fee amount a team
        /// has to pay to play on this tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the teams takes part on this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the list of Prizes for this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the Rounds of the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
