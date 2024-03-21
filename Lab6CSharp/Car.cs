using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    class Car : Trans
    {
        public Car(string brand, string number, int speed, int capacity)
        {
            this.Brand = brand;
            this.Number = number;
            this.Speed = speed;
            this.Capacity = capacity;
        }

        public string Brand { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public int Capacity { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Car - Brand: {Brand}, Number: {Number}, Speed: {Speed}, Capacity: {Capacity}");
        }
    }
}
