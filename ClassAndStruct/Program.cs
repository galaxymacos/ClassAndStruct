using System;

namespace ClassAndStruct
{
    class TimePeriod
    {
        private int _seconds;

        public int Hours
        {
            get => _seconds / 3600;
            set
            {
                if (value<0||value>24)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} should be in the range of 0 and 24");
                }

                _seconds = value * 3600;
            }
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            var timePeriod = new TimePeriod {Hours = 10};
            Console.WriteLine(timePeriod.Hours);
        }
    }
}