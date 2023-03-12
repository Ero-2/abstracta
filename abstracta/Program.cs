using abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace abstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo Circulo1 = new Circulo(2);
            Triangulo triangulo1 = new Triangulo(2, 4);
            Rectangulo rectangulo1 = new Rectangulo(2, 8);
            Console.WriteLine(Circulo1);
            Console.WriteLine(triangulo1);
            Console.WriteLine(rectangulo1);
            Console.ReadKey();
        }
    }
    abstract class figuraGeo
    {
        private string nameless;
        public abstract double Area();

        public figuraGeo(string nombre)
        {
            nameless= nombre;
        }

        public override string ToString()
        {
            return "area de un " + nameless+ "=" + Area();
        }

    }


    class Triangulo : figuraGeo
    {
        private double b, h;

        public Triangulo(double b, double h) : base ("triangulo")
        {
            this.b = b;
            this.h = h;
        }
        public override double Area()
        {
            return b * h / 2;
        }
    }
    class Rectangulo : figuraGeo
    {
        private double b, h;

        public Rectangulo(double b, double h): base ("rectangulo")
        {
            this.b = b;
            this.h = h;
        }
        public override double Area()
        {
            return b * h;
        }
    }
    class Circulo : figuraGeo
    {
        private double radio;

        public Circulo(double r) : base("circulo")
        {
            radio = r;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(2, radio);
        }
    }

}

    


