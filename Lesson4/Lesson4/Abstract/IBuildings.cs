using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public interface IBuildings
    {
        public int IdBulding { get; }

        public double HeightBuilding { get; set; }

        public int FloorsCount { get; set; }

        public int EntrancesCount { get; set; }

        public int FlatsCount { get; set; }
        
        public double HeightFloor { get; }
        
        public int FlatsCountPerEntrance { get; }

        public int FlatsCountPerFloor { get; }
        
    }
}
