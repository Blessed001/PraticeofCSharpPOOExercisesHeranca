using System;

namespace Exe11PraPOOHeranca
{

    public class Quadrado
    {
        protected int Comprimento;
        public Quadrado (int C)
        {
            Comprimento = C;
        }
        public virtual int Area()
        {
            return Comprimento * Comprimento;
        }
        public string Lado()
        {
            return Comprimento.ToString();
        }

    }
    public class Retangulo:Quadrado
    {
        private int Largura;
        public Retangulo(int C, int L) : base(C)
        {
            Largura = L;
        }
        public override int Area()
        {
            return Comprimento * Largura;
        }
        public string Dimensoes()
        {
            return Comprimento + "x" + Largura;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado Q = new Quadrado(4);
            Retangulo R = new Retangulo(4, 3);
            Console.WriteLine("Area do quadrado com lado {0} = {1}", Q.Lado(), Q.Area());
            Console.WriteLine("Area do retangulo com dimensoes {0} = {1}", R.Dimensoes(), R.Area());
            Console.ReadKey();
        }
    }
}
