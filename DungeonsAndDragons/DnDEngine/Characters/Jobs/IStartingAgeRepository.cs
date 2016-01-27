using System;

namespace DnDEngine.Characters.Jobs
{
    public interface IStartingAgeRepository
    {
        void Insert(StartingAge entity);
        void Update(StartingAge entity);
        StartingAge Get(Guid jobId, Guid raceId);
        void Delete(StartingAge entity);
    }
}