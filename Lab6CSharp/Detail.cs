using Lab6CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class Detail : IDetail, IComparable
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Назва: " + Name);
            Console.WriteLine("Вага: " + Weight + " г");
        }

        public int CompareTo(object? obj)
        {
            Detail? detail = obj as Detail;
            if (detail != null)
            {
                return detail.Weight == this.Weight ? 0 : detail.Weight < this.Weight ? 1 : -1;
            }
            throw new ArgumentException("Object type must be detail");
        }

        public Detail()
        {
            Name = "default detail";
            Weight = 100;
        }
        public Detail(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
        public Detail(Detail a)
        {
            Name = a.Name;
            Weight = a.Weight;
        }
        ~Detail()
        {
            Console.WriteLine("Detail destroyed");
        }
    }
}
