using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson4
{
    public class Creator
    {
        private static Hashtable _hashTable = new Hashtable();

        private Creator() { }

        public static IBuildings CreateBuild() 
        {
            var building = new Building();
            try
            {
                _hashTable.Add(building.IdBulding, building);
                return building;
            }
            catch
            {
                Console.WriteLine($"An element with Key = {building.IdBulding} already exists.");
                building = null;
            }
            return building;
        }
        public static void RemoveBuild(int IdBulding)
        {
            try
            {
                if (_hashTable.ContainsKey(IdBulding))
                {
                    _hashTable.Remove(IdBulding);
                    Console.WriteLine($"Removing build {IdBulding} is succesed");
                }
                else
                {
                    Console.WriteLine($"The build {IdBulding} does not exist");
                }
                
            }
            catch
            {
                Console.WriteLine($"Error during remove build {IdBulding}.");
            }
        }
    }
}
