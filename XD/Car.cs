using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD
{
    public class Car:Vehicul
    {
        private string color;
        private string name;
        private int maxSpeed;
        private int year;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Year
        {
            get { return year; }
            set
            {
                try
                {
                    if (value < 1980)
                    {
                        throw new Exception("Please pass a correct value");
                    }
                    else
                    {
                        year = value;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error "+ ex.Message);
                }
                
            }
        }
        public Car(string colorName, string nameName, int maxSpeedValue, int yearValue)
        {
            Color = colorName;
            Name = nameName;
            maxSpeed = maxSpeedValue;
            Year = yearValue;
        }
        public Car(string colorName, string nameName, int maxSpeedValue, int yearValue, string eng_type)
        {
            Color = colorName;
            Name = nameName;
            maxSpeed = maxSpeedValue;
            Year = yearValue;
            engine_type = eng_type;
        }
        public Car(string nameName)
        {
            name = nameName;
        }
        public void fullThrottle()
        {
            Console.WriteLine("is going at the speed of " + maxSpeed);
        }

    }
}
