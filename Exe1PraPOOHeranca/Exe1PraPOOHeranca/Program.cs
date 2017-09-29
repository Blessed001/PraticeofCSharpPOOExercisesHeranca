using System;

namespace Exe1PraPOOHeranca
{
    public class Centro
    {
        private int x, y;
        public Centro ()
        {
            x = 0;
            y = 0;
        }
        public Centro (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void CoordCentro()
        {
            Console.WriteLine("Centro = ( {0}, {1} )", x, y);
        }
    }
    public class Circulo : Centro
    {
        private double Raio;
        public Circulo ()
        {

        }
        public Circulo(int x,int y, double R): base (x,y)
        {
            Raio = R;
        }
        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Raio, 2), 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = 4;
            Circulo[] C = new Circulo[N];
            int X = 0, Y = 0;
            double R = 0.5;
            for (int I =0; I<C.Length;I++)
            {
                C[I] = new Circulo(X, Y, R);
                C[I].CoordCentro();
                Console.WriteLine("Area = {0}", C[I].Area());
                X++;
                Y++;
                R *= 2;
            }
            Console.ReadKey();

        }
    }
}
