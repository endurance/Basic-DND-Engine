using DnDEngine.Characters.Jobs;
using DnDEngine.Characters.Races;
using DnDEngine.Roller;

namespace DnDEngine.Characters.Age
{
    class StartingAgeService
    {
        public StartingAgeService(IStartingAgeRepository startingAgeRepository)
        {
            StartingAgeRepository = startingAgeRepository;
        }

        private IStartingAgeRepository StartingAgeRepository { get; }
        public int GetStartingAge(Race race, Job job)
        {
            StartingAge obj = StartingAgeRepository.Get(job.Id, race.Id);
            int age = race.AgeOfAdulthood;
            return age + DiceRoller.RollDice(obj.NumberOfDice, obj.NumberOfSides);
        }
    }
}
