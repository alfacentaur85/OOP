using System;
using Lesson4;

namespace TestLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildingA = Creator.CreateBuild();
            Console.WriteLine($"Дом №: {buildingA.IdBulding}. Построен");
            var buildingB = Creator.CreateBuild();
            Console.WriteLine($"Дом №: {buildingB.IdBulding}. Построен");
            var buildingC = Creator.CreateBuild();
            Console.WriteLine($"Дом №: {buildingC.IdBulding}. Построен");

            buildingA.EntrancesCount = 5;
            buildingA.FlatsCount = 300;
            buildingA.FloorsCount = 3;
            buildingA.HeightBuilding = 400.80;

            Console.WriteLine($"Дом №: {buildingA.IdBulding}");
            Console.WriteLine($"Этажей: {buildingA.FloorsCount}");
            Console.WriteLine($"Подъездов: {buildingA.EntrancesCount}");
            Console.WriteLine($"Квартир: {buildingA.FlatsCount}");
            Console.WriteLine($"Высота дома: {buildingA.HeightBuilding}");
            Console.WriteLine($"Высота этажа: {buildingA.HeightFloor}");
            Console.WriteLine($"Квартир в подъезде: {buildingA.FlatsCountPerEntrance}");
            Console.WriteLine($"Квартир на этаже: {buildingA.FlatsCountPerFloor}");

            Creator.RemoveBuild(2);

            Creator.RemoveBuild(52);


        }
    }
}
