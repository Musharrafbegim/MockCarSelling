using System;
using System.Collections.Generic;

namespace Mock
{
    public class CarData
    {
        // creating list
        public List<CarModel> CarModels { get; set; }

        public static CarData ourCar;

        public CarData carSelling;

        //we will pass string value from console
        private string line;

        public CarData()
        {
            // initialize list
            CarModels = new List<CarModel>();
        }

        public static CarData GetCars()
        {
            if (ourCar == null)
            {
                ourCar = new CarData();
            }

            return ourCar;
        }


        // dummy data function
        public void PopulateCarsForTest()
        {
            carSelling = GetCars();
            // passing dummy data
            Passenger cars1 = new Passenger()
            {
                ID = 1,
                Model = "Spark",
                Price = 2000,
                ProdYear = 2015,
                Condition = CarModel.condtion.Excellent,
                Brand = "Chevrolet",
                ElecticCar = false
            };
            // adding dummy data to our list
            carSelling.CarModels.Add(cars1);
            Passenger cars2 = new Passenger()
            {
                ID = 2,
                Model = "Malibu",
                Price = 25000,
                ProdYear = 2019,
                Condition = CarModel.condtion.Bad,
                Brand = "Chevrolet",
                ElecticCar = false
            };
            carSelling.CarModels.Add(cars2);
            Passenger cars3 = new Passenger()
            {
                ID = 3,
                Model = "Model S",
                Price = 80000,
                ProdYear = 2020,
                Condition = CarModel.condtion.Excellent,
                Brand = "Tesla",
                ElecticCar = true
            };
            carSelling.CarModels.Add(cars3);
            Passenger cars4 = new Passenger()
            {
                ID = 4,
                Model = "Plaid",
                Price = 120000,
                ProdYear = 2021,
                Condition = CarModel.condtion.Excellent,
                Brand = "Tesla",
                ElecticCar = true
            };
            carSelling.CarModels.Add(cars4);
            // show each our result that we have in the list to our console
            foreach (Passenger car in carSelling.CarModels)
            {
                Console.WriteLine("ID: " + car.ID + " Model: " + car.Model + " Price: " + car.Price + " ProdYear: "
                                  + car.ProdYear + " Condition: " + car.Condition + " Brand: " + car.Brand +
                                  " Electric Car: " + car.ElecticCar);
            }
        }

        public void FindModelCar()
        {
            Console.WriteLine("Type brand of car:");
            // getting user input from console
            line = Console.ReadLine();
            foreach (CarModel car in carSelling.CarModels)
                if (line == car.Brand && line != null)
                {
                    Console.WriteLine("ID: " + car.ID + " Model: " + car.Model + " Price: " + car.Price + " ProdYear: "
                                      + car.ProdYear + " Condition: " + car.Condition + " Brand: " + car.Brand);
                }
        }
    }
}