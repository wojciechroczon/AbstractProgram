using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a;

            //Console.WriteLine("Podaj wymiar boku kwadratu:");
            //Console.ReadLine();
            //Square powierzchnia = new Square(50);
            //powierzchnia.Display();

            //Circle circ = new Circle(56);

            Figure[] figures = new Figure[3];  //to tworzy tablicę obiektów na podstawie klasy Figure
            figures[0] = new Square(6);
            figures[1] = new Circle(6);
            figures[2] = new Square(9);

            foreach (var item in figures)
            {
                item.Print(); 

            }

            Console.ReadLine();

                    }
    }
}
