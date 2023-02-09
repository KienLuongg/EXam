using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_EXAM.ex_2
{
    public abstract class Base
    {
        public double weight;
        public string name;

        public Base() { }
        public Base(double weight, string name) 
        {
            this.weight = weight;
            this.name = name;
        }

        public abstract void Show();

        public abstract void SetMe(double weight, string name);
        
    }
}
