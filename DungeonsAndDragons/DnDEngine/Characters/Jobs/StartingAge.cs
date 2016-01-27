using System;

namespace DnDEngine.Characters.Jobs
{
    public class StartingAge
    {
        public Guid JobId { get; set; }
        public Guid RaceId { get; set; }
        public int NumberOfDice { get; set; }
        public int NumberOfSides { get; set; }
    }
}