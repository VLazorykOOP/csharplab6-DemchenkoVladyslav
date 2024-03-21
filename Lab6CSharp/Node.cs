using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class Node : Detail
    {
        public string Type { get; set; }

        public Node(string name, int weight, string type) : base(name, weight)
        {
            Type = type;
        }
        public Node()
        {
            Name = "default detail";
            Weight = 1;
            Type = "standart";
        }
        public Node(Node a)
        {
            Name = a.Name;
            Weight = a.Weight;
            Type = a.Type;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Тип: " + Type);
        }
    }
}
