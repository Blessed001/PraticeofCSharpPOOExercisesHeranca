using System;

namespace Exe8PraPOOHeranca
{
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
    }
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
    public class Amigos:Pessoa
    {
        private DataCronologica Nasc;
        public Amigos (string N, DataCronologica D): base (N)
        {
            Nasc = D;
        }
        public DataCronologica Nascimento
        {
            get { return Nasc; }
            set { Nasc = value; }
        }
    }
    class Program
    {
        private static void Impressao(Amigos A)
        {
            Console.WriteLine(A.Nomes);
            DataCronologica Ddata = A.Nascimento;
            Console.WriteLine(Ddata.Dias + "/" + Ddata.Meses + "/" + Ddata.Anos);
        }
        static void Main(string[] args)
        {

            String N1 = "Sara Tavares";
            String N2 = "Antonio Ribeiro";
            Amigos A1 = new Amigos(N1, new DataCronologica(15, 5, 1996));
            Amigos A2 = new Amigos(N2, new DataCronologica(15, 12, 1986));
            Impressao(A1);
            Impressao(A2);
            Console.ReadKey();
        }
    }
}
