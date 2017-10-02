using System;

namespace Exe4PraPOOHeranca
{
    public class Pessoa
    {
        private string Nome;
        private int Tel;
        public Pessoa ()
        {
            Nome = "";
            Tel = 0;
        }
        public Pessoa(string n, int t)
        {
            Nome = n;
            Tel = t;
        }
        public string Pnome
        {
            get { return Nome; }
        }
        public int Ptel
        {
            get { return Tel; }
        }
    }
    public class Amigo:Pessoa
    {
        private string Onde;
        private string Quando;
        public Amigo (string n, int t, string o, string q): base (n,t)
        {
            Onde = o;
            Quando = q;
        }
        public string Ponde
        {
            get { return Onde; }
        }
        public string Pquando
        {
            get { return Quando; }
        }
    }
    public class Colega:Pessoa 
    {
        private string Local;
        private string Profissao;
        public Colega(string n, int t, string l, string p): base (n,t)
        {
            Local = l;
            Profissao = p;
        }
        public string Plocal
        {
            get { return Local; }
        }
        public string Pprofissao
        {
            get { return Profissao; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] NomesA = { "Teresa G.", "Rui O.", "Ilda J." };
            string[] NomesC = { "Rui Alves", "J. Pereira" };
            int[] TelefA = { 23432343, 23454325, 334534234 };
            int[] TelefC = { 34534534, 34523322 };
            string[] OndeA = { "Lancs", "Kent", "Warsaw" };
            string[] OndeC = { "Porto", "Lisboa" };
            string[] QuandoA = { "2007", "2002", "1993" };
            string[] ProfissaoC = { "Economista", "Enginheiro" };
            int TA = NomesA.Length;
            int TC = NomesC.Length;
            Amigo[] A = new Amigo[3];
            Colega[] C = new Colega[3];
            int i;
            for (i = 0; i < TA; i++)
            {
                A[i] = new Amigo(NomesA[i], TelefA[i], OndeA[i], QuandoA[i]);
            }
            for (i = 0; i < TC; i++)
            {
                C[i] = new Colega(NomesC[i], TelefC[i], OndeC[i], ProfissaoC[i]);
            }
            Console.WriteLine("Lista de Amigos");
            for (i = 0; i < TA; i++) 
            {
                Console.WriteLine(A[i].Pnome.PadRight(15) + A[i].Ponde.PadRight(20));
            }
            Console.WriteLine("\nLista de colegas");
            for (i = 0; i < TC; i++)
            {
                Console.WriteLine(C[i].Pnome.PadRight(15) + C[i].Pprofissao.PadRight(20));
            }
            Console.ReadKey();
        }
    }
}
