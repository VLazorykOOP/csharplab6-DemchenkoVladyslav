using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class Mechanism : Detail
    {
        public int NumParts { get; set; }

        public Mechanism(string name, int weight, int numParts) : base(name, weight)
        {
            NumParts = numParts;
        }
        public Mechanism()
        {
            Name = "default detail";
            Weight = 1;
            NumParts = 1;
        }
        public Mechanism(Mechanism a)
        {
            Name = a.Name;
            Weight = a.Weight;
            NumParts = a.NumParts;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Кількість частин: " + NumParts);
        }

    }
}
