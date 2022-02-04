using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{

    class Student
    {
        private int rn = 5;
        private string name;

        public int RollNumber
        {
            get
            {
                return rn;
            }
            set
            {
                rn = value;
            }
        }
        public string Name { get; set; }
    }
    class Program3
    {
        public static void Main3()
        {
            Student objStudent = new Student();
            objStudent.Name = "Value";
            Console.WriteLine(objStudent.RollNumber);
            Console.WriteLine(objStudent.Name);
            Console.ReadLine();
        }

    }
}