using System;
using System.Collections.Generic;
using System.Text;

namespace three
{
    static class Pg9
    {
        static void Main9(string[] args)
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person("Saisri");
            apartment.door = new House.Door("burgundy");
            person.house = apartment;
            person.ShowData();
        }
    }

    public class House
    {
        public int Area { get; set; }
        public Door door;

        public House(int area = 200)
        {
            Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"house area is {Area} m2");
        }

        public Door GetDoor()
        {
            return door;
        }

        public class Door
        {
            public string Color { get; set; }

            public Door(string color = "brown")
            {
                Color = color;
            }

            public void ShowData()
            {
                Console.WriteLine($"Door color-> {Color}");
            }
        }
    }

    public class SmallApartment : House
    {
        public SmallApartment(int area = 50) : base(area)
        {
        }
    }

    public class Person
    {
        private string name;
        public House house { get; set; }

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"Person Name -> {name}");
            Console.WriteLine("house details :");
            house.ShowData();
            Console.WriteLine("Door details:");
            house.GetDoor().ShowData();
        }
    }
}