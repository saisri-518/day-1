﻿using System;

public class Pg6
{
    public static void Main3(string[] args)
    {
        Car car = new Car(0);

        int fuel = int.Parse(Console.ReadLine());
        if (car.Refuel(fuel))
        {
            car.Drive();
        }
    }

    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not fuel");
                Console.ReadLine();
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
}
