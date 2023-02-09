using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_EXAM.ex_1
{
    public class Cylinder
    {
        private double radius;
        private double height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;


        public double Radius { get => radius; set => radius = value; }
        public double Height { get=> height; set => height = value; }
        public double BaseArea { get => baseArea; set => baseArea = value; }
        public double LateralArea { get => lateralArea; set => lateralArea = value; }
        public double TotalArea { get => totalArea; set => totalArea = value; }
        public double Volume { get => volume; set => volume = value; }
        

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
            Process();
        }

        public Cylinder() { }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Radius + Height);
            Volume = Math.PI * Radius * Radius * Height;

        }

        public void Result()
        {
            Console.WriteLine("/nCylinder Characteristics");
            Console.WriteLine("Radius: " + Radius + ", Height: " + Height);
            Console.WriteLine("Base: " + string.Format("{0:0.00}", BaseArea) + " | Lateral: " + string.Format("{0:0.00}", LateralArea) + " | ToTal: " + string.Format("{0:0.00}", TotalArea) + " | Volumn: " + string.Format("{0:0.00}", Volume));
        }
    }
}
