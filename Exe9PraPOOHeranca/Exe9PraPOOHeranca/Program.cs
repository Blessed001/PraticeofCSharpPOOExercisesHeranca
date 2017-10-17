using System;

namespace Exe9PraPOOHeranca
{
    public class Pessoa
    {
        private string Nome;
        public Pessoa(string N)
        {
            Nome = N;
        }
        public string Nomes
        {
            get { return Nome; }
            set { Nome = value; }
        }
    }
    public class Amigo:Pessoa
    {
        private DataCronologica Nasc;
        public Amigo(string N, DataCronologica C) : base(N)
        {
            Nasc = C;
        }
        public DataCronologica Nascimento
        {
            get { return Nasc; }
            set { Nasc = value; }
        }
    }
    public class DataCronologica
    {
        private int Dia, Mes, Ano;
        public DataCronologica(int D, int M, int A)
        {
            Dia = D;
            Mes = M;
            Ano = A;
        }
        public int Dias
        {
            get { return Dia; }
            set { Dia = value; }
        }
        public int Meses
        {
            get { return Mes; }
            set { Mes = value; }
        }
        public int Anos
        {
            get { return Ano; }
            set { Ano = value; }
        }
        public int Idade(int C)
        {
            return C - Ano;
        }
        public static bool Bissexto(int A)
        {
            if((A % 4 == 0 && A % 100 != 0) || (A % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int DiaDoAno(DataCronologica X)
        {
            int TD = 0;
            int[] DiaMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (Bissexto(X.Ano) == true )
            {
                DiaMeses[1] = DiaMeses[1] + 1;
                for (int M = 0; M < X.Mes - 1; M++)
                {
                    TD += DiaMeses[M];
                }
            }TD += X.Dia;
            return TD;
        }
        public int Idade(DataCronologica C)
        {
            int Inic = DiaDoAno(this);
            int Fim = DiaDoAno(C);
            int TD = 0;
            if (this.Ano == C.Ano)
            {
                TD = Fim - Inic;
            }
            else
            {
                TD = 365 - DiaDoAno(this);
                if (Bissexto(this.Ano) == true)
                    TD++;
                for (int i =this.Ano + 1; i <= C.Ano - 1; i++)
                {
                    TD += 365;
                    if (Bissexto(i) == true)
                        TD++;
                }
                TD += Fim;

            }
            return TD;

        }
    }
    class Program
    {
        public static void Impressao(Amigo A)
        {
            DataCronologica Ddata = A.Nascimento;
            DateTime Hoje = System.DateTime.Now;
            DataCronologica C = new DataCronologica(Hoje.Day, Hoje.Month, Hoje.Year);
            Console.WriteLine("Este ano {0} faz {1} anos", A.Nomes, Ddata.Idade(Hoje.Year));
            Console.WriteLine("Ate hoje ja viveu {0} dias", Ddata.Idade(C));
        }
        static void Main(string[] args)
        {
            String N = "Sara Tavares";
            DataCronologica D = new DataCronologica(15, 5, 1996);
            Amigo A = new Amigo(N, D);
            Impressao(A);
            Console.ReadKey();
        }
    }
}
