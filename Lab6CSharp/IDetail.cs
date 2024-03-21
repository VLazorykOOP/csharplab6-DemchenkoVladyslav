using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public interface IDetail
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public virtual void Show()
        {

        }
    }
}
