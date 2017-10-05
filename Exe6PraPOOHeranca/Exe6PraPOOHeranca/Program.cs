using System;

namespace Exe6PraPOOHeranca
{
    public class Vendas
    {
        private static double ValorTotal = 0;
        public static double ActualozarVendas(double x)
        {
            return ValorTotal += x;
        }
        public static double GetValorTotal()
        {
            return ValorTotal;
        }
    }
    public class VendasPradA : Vendas
    {
        private int Quant;
        private double ValorUnitl;
        public VendasPradA(int q, double v)
        {
            Quant = q;
            ValorUnitl = v;
            ActualozarVendas(v * q);
        }
    }
    public class VendasProdB : Vendas
    {
        private double ValorTras;
        public VendasProdB(double v)
        {
            ValorTras = v;
            ActualozarVendas(v);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            VendasPradA PA1 = new VendasPradA(4, 5);
            VendasProdB PB1 = new VendasProdB(300);
            VendasPradA PA2 = new VendasPradA(5, 7);
            VendasPradA PA3 = new VendasPradA(10, 4);
            VendasProdB PB2 = new VendasProdB(100);

            Console.WriteLine("Total de Vendas {0} ", Vendas.GetValorTotal());
            Console.ReadKey();

        }
    }
}
