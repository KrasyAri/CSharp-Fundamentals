using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
           
            var command = Console.ReadLine();
            
            while (command != "End")
            {
                var commandElements = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Vehicle vehicle = new Vehicle(commandElements[0], commandElements[1], commandElements[2], int.Parse(commandElements[3]));

                vehicles.Add(vehicle);

                command = Console.ReadLine();
            }

            string modelToPrint = Console.ReadLine();

            while (modelToPrint != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.FirstOrDefault(x => x.ModelOfVehicle == modelToPrint).ToString());
                modelToPrint = Console.ReadLine();
            }

            var cars = vehicles.FindAll(x => x.TypeOfVehicle == "car");
            var carsHorsePower = cars.Sum(c => c.HorsepowerOfVehicle);
            var avvCarsPower = carsHorsePower / cars.Count;

            var trucks = vehicles.FindAll(x => x.TypeOfVehicle == "truck");
            var truckHorsePower = trucks.Sum(t => t.HorsepowerOfVehicle);
            var avvTruckPower = truckHorsePower / trucks.Count;

            if (cars.Count == 0)
            {
                avvCarsPower = 0;
            }
            if (trucks.Count == 0)
            {
                avvTruckPower = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {avvCarsPower:f2}.");
           
            Console.WriteLine($"Trucks have average horsepower of: {avvTruckPower:f2}.");

        }
    }

    public class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string ModelOfVehicle { get; set; }
        public string ColourOfVehicle { get; set; }
        public double HorsepowerOfVehicle { get; set; }

        public Vehicle(string type, string model, string colour, double horsepower)
        {
            this.TypeOfVehicle = type;
            this.ModelOfVehicle = model;
            this.ColourOfVehicle = colour;
            this.HorsepowerOfVehicle = horsepower;
        }

        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();

            if (this.TypeOfVehicle == "car")
            {
                sb.AppendLine($"Type: Car");
            }
            else
            {
                sb.AppendLine($"Type: Truck");
            }

            sb.AppendLine($"Model: {this.ModelOfVehicle}");
            sb.AppendLine($"Color: {this.ColourOfVehicle}");
            sb.AppendLine($"Horsepower: {this.HorsepowerOfVehicle}");

            return sb.ToString().TrimEnd();
        }
    }

}

