using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FINAL_EXAM.ex_2
{
    public class Tiger : Base
    {
        public Tiger() { }
        public Tiger(double weight, string name):base(weight, name) { }

        public override void Show()
        {
            Console.WriteLine("Name: " + name + ", Weight: " + weight);
        }

        public override void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}
