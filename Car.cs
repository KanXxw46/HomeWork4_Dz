using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HomeWork4_Dz
{
    class Car
    {
        private string number;
        private string color;
        private string model;
        private int speed;
        private int price;
        public int size { get; set; }
        public DateTime date { get; set; }
        public string wheel { get; set; }
        public override string ToString()
        {
            return "Name: {0}\n Size: {1}\n Date: {2}\n wheel: {3}\n" +  + size + date + wheel;
        }

        public string CarNumber
        {
            get
            {
                return number;
            }
        }
        public string CarColor
        {
            get
            {
                return color;
            }
        }
        public string CarModel
        {
            get
            {
                return model;
            }
        }
        public int CarSpeed
        {
            get
            {
                return speed;
            }
        }
        public int CarPrice
        {
            get
            {
                return price;
            }
        }
        public static int Type;
        public static int Power;

        static Car()
        {
            Console.WriteLine("Car in Shop");
        }
        public static int Cars = 10;
    }
}
