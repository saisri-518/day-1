using System;
using System.Collections.Generic;
using System.Text;

namespace three
{
    class Square
    {

        private int x;
        private int y;
        private int length;
        public Square(int x, int y, int length)
        {
            this.x = x;
            this.y = y;
            this.length = length;
        }
        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Scale(int scaleFactor)
        {
            this.length *= scaleFactor;
        }
        public override string ToString()
        {
            return string.Format("move ({0},{1}), side {2}", this.x, this.y, this.length);
        }
        public double GetPerimeter()
        {
            return 4 * this.length;
        }
        public double GetArea()
        {
            return this.length * this.length;
        }
    }

    class Pg8
    {

        static void Main8(string[] args)
        {

            Square square = new Square(5, 5, 10);
            Console.WriteLine(square.ToString());

            square.Move(15, 20);
            Console.WriteLine(square.ToString());

            square.Scale(3);
            Console.WriteLine(square.ToString());
            Console.WriteLine("\nThe perimeter = {0}", square.GetPerimeter());
            Console.WriteLine("\nThe area = {0}", square.GetArea());


            Console.ReadLine();
        }
    }
}