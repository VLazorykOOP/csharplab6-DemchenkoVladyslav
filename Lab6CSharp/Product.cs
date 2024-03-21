using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class Product : Detail
    {
        public string Material { get; set; }

        public Product(string name, int weight, string material) : base(name, weight)
        {
            Material = material;
        }
        public Product()
        {
            Name = "default detail";
            Weight = 1;
            Material = "wood";
        }
        public Product(Product a)
        {
            Name = a.Name;
            Weight = a.Weight;
            Material = a.Material;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Матеріал: " + Material);
        }
    }
}
