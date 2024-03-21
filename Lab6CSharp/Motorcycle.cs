using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    class Motorcycle : Trans
    {
        private bool hasSidecar;
        public Motorcycle(string brand, string number, int speed, int capacity, bool hasSidecar)
        {
            this.Brand = brand;
            this.Number = number;
            this.Speed = speed;
            this.Capacity = capacity;
            this.hasSidecar = hasSidecar;
            if (!hasSidecar)
            {
                this.Capacity = 0;
            }
        }

        public string Brand { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public int Capacity { get; set; }


        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Motorcycle - Brand: {Brand}, Number: {Number}, Speed: {Speed}, Capacity: {Capacity}");
        }

        public bool Equals(Trans? other)
        {
            if (other == null) return false;
            var o = other as Motorcycle;
            if (o.Brand == this.Brand && o.Number == this.Number && o.Speed == this.Speed && o.Capacity == this.Capacity && hasSidecar == o.hasSidecar)
                return true;
            return false;
        }
        public int CompareTo(object? obj)
        {
            var m = obj as Motorcycle;
            if (m == null) throw new ArgumentException();
            return (m.Speed == this.Speed) ? 0 : (m.Speed < this.Speed) ? 1 : -1;
        }
    }
}
