using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    class Truck : Trans
    {
        private bool hasTrailer;
        public Truck(string brand, string number, int speed, int capacity, bool hasTrailer)
        {
            this.Brand = brand;
            this.Number = number;
            this.Speed = speed;
            this.Capacity = capacity;
            this.hasTrailer = hasTrailer;
            if (hasTrailer)
            {
                this.Capacity *= 2;
            }
        }

        public string Brand { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public int Capacity { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Truck - Brand: {Brand}, Number: {Number}, Speed: {Speed}, Capacity: {Capacity}");
        }
        public bool Equals(Trans? other)
        {
            var o = other as Truck;
            if (o == null) return false;
            if (o.Brand == this.Brand && o.Number == this.Number && o.Speed == this.Speed && o.Capacity == this.Capacity && hasTrailer== o.hasTrailer)
                return true;
            return false;
        }
        public int CompareTo(object? obj)
        {
            var t = obj as Trans;
            if (t == null) throw new ArgumentException();
            return (t.Capacity == this.Capacity) ? 0 : (t.Capacity < this.Capacity) ? 1 : -1;
        }
        public int CompareTo(int a)
        {
            return (a == this.Capacity) ? 0 : (a < this.Capacity) ? 1 : -1;
        }
    }

}
