using System;

namespace ClassAndStruct
{
    struct Circle
    {
        public double Radius
        {
            get { return Math.Sqrt(Area / Math.PI); }
            set
            {   
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                Radius = value;
            }
        }

        public double Area
        {
            get => Radius * Radius  * Math.PI;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value)+" should be greater than 0");
                Radius = Math.Sqrt(value / Math.PI);
                Area = value;
            }
        }
    }
    
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Circle();
            c.Area = 100;
            Console.WriteLine(c.Area);
        }
    }
}