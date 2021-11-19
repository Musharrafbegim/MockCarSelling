using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Mock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Searcher!");
            // нужно запустить нашу функцию которая будет генерировать dummy data
            CarData car = new CarData();
            car.PopulateCarsForTest();
            car.FindModelCar();
        }
    }
}
