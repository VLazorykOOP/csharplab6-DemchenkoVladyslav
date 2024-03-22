using System;
using System.Collections;
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
        public bool Equals(Trans? other)
        {
            
            var o = other as Car;
            if (o == null) return false;
            if (o.Brand == this.Brand && o.Number == this.Number && o.Speed == this.Speed && o.Capacity == this.Capacity)
                return true;
            return false;
        }
        public int CompareTo(object? obj)
        {
            var c = obj as Trans;
            if (c == null) throw new ArgumentException();
            return (c.Speed == this.Speed) ? 0 : (c.Speed < this.Speed) ? 1 : -1;
        }
        public int CompareTo(int a)
        {
            return (a == this.Capacity) ? 0 : (a < this.Capacity) ? 1 : -1;
        }
    }
}
