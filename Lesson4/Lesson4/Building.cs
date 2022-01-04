using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Building : IBuildings
    {
        private static int _counter = 0;

        private int _idBulding = -1;

        private double _heightBuilding = -1.0;

        private int _floorsCount = -1;

        private int _entrancesCount = -1;

        private int _flatsCount = -1;

        public int IdBulding
        {
            get
            {
                return _idBulding;
            }
            private set
            {
                _idBulding = value;
            }
        }

        public double HeightBuilding
        {
            get
            {
                return _heightBuilding;
            }
            set
            {
                _heightBuilding = value;
            }
        }

        public int FloorsCount
        {
            get
            {
                return _floorsCount;
            }
            set
            {
                _floorsCount = value;
            }
        }

        public int EntrancesCount
        {
            get
            {
                return _entrancesCount;
            }
            set
            {
                _entrancesCount = value;
            }
        }

        public int FlatsCount
        {
            get
            {
                return _flatsCount;
            }
            set
            {
                _flatsCount = value;
            }
        }

        public double HeightFloor
        {
            get
            {
                return _heightBuilding / _floorsCount;
            }
        }

        public int FlatsCountPerEntrance
        {
            get 
            {
                double result = _flatsCount / _entrancesCount;
                return (int) Math.Floor(result);
            }
        }

        public int FlatsCountPerFloor
        {
            get
            {
                double result = FlatsCountPerEntrance / _floorsCount;
                return (int) Math.Floor(result);
            }
        }

        public Building()
        {
            IdBulding = ++_counter;
        }


         



    }
}
