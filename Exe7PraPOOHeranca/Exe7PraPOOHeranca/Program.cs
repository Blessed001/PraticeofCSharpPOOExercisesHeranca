using System;

namespace Exe7PraPOOHeranca
{
    public class Propriedade
    {
        private string Proprietario;
        private int NFiscal;
        public Propriedade(string Pr, int NF)
        {
            Proprietario = Pr;
            NFiscal = NF;
        }
        public override string ToString()
        {
            return Proprietario + " ---- " + NFiscal + " ---- ";
        }
        public int RendaMinima(double Area)
        {
            double Renda;
            const double P1 = 0.20;
            const double P2 = 0.30;
            if (Area < 50)
            {
                Renda = 100;
            }
            else if (Area < 100)
            {
                Renda = 100 + P1 * Area;
            }
            else
            {
                Renda = 100 + P2 * Area;
            }
            return (int)Math.Round(Renda, 0);          
        }
    }
    public class Moradia:Propriedade
    {
        private string Local;
        private char Categoria;
        public Moradia(string Pr, int NF, string L) : base(Pr,NF)
        {
            Local = L;
            CategMoradia();
        }
        public char CategMoradia()
        {  
            switch (Local)
            {
                case "Lisboa":
                    Categoria = 'A';
                    break;
                case "Porto":
                    Categoria = 'B';
                    break;
                case "Coimbra":
                    Categoria = 'C';
                    break;
                case "Braga":
                    Categoria = 'D';
                    break;
            }
            return Categoria;
        }
        public int RendaMinima()
        {
            int Renda = 0;
            switch (Categoria)
            {
                case 'A':
                case 'B':
                    Renda = 1000;
                    break;
                case 'C':
                    Renda = 600;
                    break;
                case 'D':
                    Renda = 450;
                    break;
            }
            return Renda;
        }
    }
    public class Apartamento:Propriedade
    {
        private string Tipo;
        private double Area;
        public Apartamento(string Pr, int NF, string T, double A) : base(Pr, NF)
        {
            Tipo = T;
            Area = A;
        }
        public double LerArea()
        {
            return Area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Moradia M = new Moradia("J & P", 50090050, "Braga");
            Apartamento Ap = new Apartamento("G & H", 50080060, "T2", 70);
            Console.WriteLine(M.ToString() + "Categoria da moradia = " + M.CategMoradia()+ " --- Renda minima = " + M.RendaMinima());
            Console.WriteLine("\n"+Ap.ToString() + "Renda minima = " + Ap.RendaMinima(Ap.LerArea()));
            Console.ReadKey();
        }
    }
}
