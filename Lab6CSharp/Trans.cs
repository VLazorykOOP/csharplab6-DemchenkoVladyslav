using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public interface Trans : IEquatable<Trans>, IComparable
    {
        public string Brand { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public int Capacity { get; set; }
        public virtual void DisplayInfo() { }

        public virtual int GetCapacity()
        {
            return Capacity;
        }
    }
}
