using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    class Square : Figure
    {//prop - ustawia wlasciwosci

        public double A { get; private set; }

        //konstruktor - ctor i dwa taby
        public Square(double a)
        {
            A=a;
        }
        public override double Area()
        {
            
            return A*A;

           }

        public override double Perimeter()
        {
            return(4*A);
        }

        public override void Print() //CTRL . wyswietla klistę możliwych metod do override
        {
            Console.WriteLine("Jestem kwadratem");
            base.Print();
        }
    }
}
