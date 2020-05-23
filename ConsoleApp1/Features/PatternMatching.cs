using ComercialRegistration;
using ConsumerVehicleRegistration;
using LiveryRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Features
{
    static class PatternMatching
    {
        public static void Run()
        {
            Car c1 = new Car() { Passengers = 2 };
            Car c2 = new Car() { Passengers = 3 };

            Taxi t1 = new Taxi();

            Bus b1 = new Bus();

            DeliveryTruck d1 = new DeliveryTruck();

            Console.WriteLine($"CalculateTollByType ({c1.GetType()}): " + CalculateTollByType(c1));
            Console.WriteLine($"CalculateTollByType ({b1.GetType()}): " + CalculateTollByType(b1));
            Console.WriteLine($"CalculateTollByType ({d1.GetType()}): " + CalculateTollByType(d1));

            Console.WriteLine($"CalculateTollByProperty ({c1.GetType()}): " + CalculateTollByProperty(c1));
            Console.WriteLine($"CalculateTollByProperty ({c2.GetType()}): " + CalculateTollByProperty(c2));
            Console.WriteLine($"CalculateTollByProperty ({b1.GetType()}): " + CalculateTollByProperty(b1));
            Console.WriteLine($"CalculateTollByProperty ({d1.GetType()}): " + CalculateTollByProperty(d1));
        }


        public static decimal CalculateTollByType(object vehicle) =>
            vehicle switch
            {
                Car c               => 2.00m,
                Taxi t              => 3.50m,
                Bus b               => 5.00m,
                DeliveryTruck dt    => 10.00m,
                { }                 => throw new ArgumentException(message: "Not a know vehicle type", paramName: nameof(vehicle)),
                null                => throw new ArgumentNullException(nameof(vehicle))
            };
        
        public static decimal CalculateTollByProperty(object vehicle) =>
            vehicle switch
            {
                Car { Passengers: 0 }   => 2.00m + 0.50m,
                Car { Passengers: 1 }   => 2.0m,
                Car { Passengers: 2 }   => 2.0m - 0.50m,
                Car c                   => 2.00m - 1.0m,

                Taxi t => t.Fares switch
                {
                    0 => 3.50m + 1.00m,
                    1 => 3.50m,
                    2 => 3.50m - 0.50m,
                    _ => 3.50m - 1.00m
                },

                Bus b when ((double)b.Riders / (double)b.Capacity) < 0.50 => 5.00m + 2.00m,
                Bus b when ((double)b.Riders / (double)b.Capacity) > 0.90 => 5.00m - 1.00m,
                Bus b => 5.00m,

                DeliveryTruck t when (t.GrossWeightClass > 5000) => 10.00m + 5.00m,
                DeliveryTruck t when (t.GrossWeightClass < 3000) => 10.00m - 2.00m,
                DeliveryTruck t => 10.00m,

                { }                             => throw new ArgumentException(message: "Not a know vehicle type", paramName: nameof(vehicle)),
                null                            => throw new ArgumentNullException(nameof(vehicle))
            };
    }
}

namespace ConsumerVehicleRegistration
{
    public class Car
    {
        public int Passengers { get; set; }
    }
}

namespace ComercialRegistration
{
    public class DeliveryTruck
    {
        public int GrossWeightClass { get; set; }
    }
}

namespace LiveryRegistration
{
    public class Taxi
    {
        public int Fares { get; set; }
    }

    public class Bus
    {
        public int Capacity { get; set; }
        public int Riders { get; set; }
    }
}