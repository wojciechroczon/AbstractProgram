using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    class Circle : Figure
    {
        public double R { get; private set; }

        public Circle(double r)
        {
            R = r;
        }
        public override double Area()
        {
            return Math.PI*Math.Pow(R,2);
        }

        public override double Perimeter()
        {
            return Math.PI * 2* R;
        }

        public virtual void DisplayCircle()
        {
            Console.WriteLine($"Pole powierzchni kola:{Area()}");
        }

        public override void Print() //CTRL . wyswietla klistę możliwych metod do override
        {
            Console.WriteLine("Jestem okregiem");
            base.Print();
        }
    }
}
