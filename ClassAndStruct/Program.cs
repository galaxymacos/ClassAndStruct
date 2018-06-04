using System;

namespace ClassAndStruct
{
    struct Circle
    {
        private double _x;
        private double _y;
        private double _radius;

        public double X
        {
            get => _x;
            set
            {
                if(value<0)
                    throw new ArgumentOutOfRangeException();
                _x = value;
            }
        }

        public double Y
        {
            get => _y;
            set
            {
                if(value<0)
                    throw new ArgumentOutOfRangeException();
                _y = value;
            }
        }

        public double Radius
        {
            get => _radius;
            set
            {
                if(value<0)
                    throw new ArgumentOutOfRangeException();
                _radius = value;
            }
        }

        public double Area => Math.Round(Radius * Radius * Math.PI,2);
        public double Perimeter => Math.Round(2 * _radius * Math.PI, 2);    
        public string Coordinate => $"({_x}, {_y})";

        public Circle(double x, double y, double radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}, {nameof(Radius)}: {Radius}";
        }

        // Struct cannot have parameterless constructor
    }
    
    class Program
    {
        private static void Main(string[] args)
        {
            Circle c1 = new Circle(1,1,10);
            Console.WriteLine(c1.Area);
            Console.WriteLine(c1.Perimeter);
            Console.WriteLine(c1.Coordinate);
            
            // change c1 
            c1.X = 2;
            c1.Y = 4;
        }
    }
}