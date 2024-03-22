using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    class Motorcycle : Trans, IEnumerator<object>
    {
        private bool hasSidecar;
        int position = 0;
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
            var o = other as Motorcycle;
            if (o == null) return false;
            if (o.Brand == this.Brand && o.Number == this.Number && o.Speed == this.Speed && o.Capacity == this.Capacity && hasSidecar == o.hasSidecar)
                return true;
            return false;
        }
        public int CompareTo(object? obj)
        {
            var m = obj as Trans;
            if (m == null) throw new ArgumentException();
            return (m.Speed == this.Speed) ? 0 : (m.Speed < this.Speed) ? 1 : -1;
        }
        public int CompareTo(int a)
        {
            return (a == this.Capacity) ? 0 : (a < this.Capacity) ? 1 : -1;
        }
        public object this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return Brand;
                    case 1: return Number;
                    case 2: return Speed;

                    case 3: return Capacity;
                    case 4: return hasSidecar;
                }
                throw new ArgumentOutOfRangeException();
            }
        }
        public IEnumerator<object> GetEnumerator()
        {
            yield return Brand;
            yield return Number;
            yield return Speed;
            yield return Capacity;
            yield return hasSidecar;
        }
        public object Current
        {
            get
            {
                try
                {
                    return this[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            position++;
            return position < 5;
        }

        public void Reset()
        {
            position = -1;
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
