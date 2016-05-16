using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDEngine.Characters.Jobs
{
    public enum Ranking
    {
        Poor,
        Good,
        Great,
        Excellent,
        Epic
    }
    public class Job
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int JobTypeId { get; set; }
        public IEnumerable<int> HitPoints { get; set; }
        public Ranking HitDice { get; set;}
        public Ranking BaseAttack { get; set;}
        public Ranking BaseSaves { get; set; }
    }
}
