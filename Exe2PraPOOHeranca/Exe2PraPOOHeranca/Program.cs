using System;

namespace Exe2PraPOOHeranca
{
    public class Escola
    {
        private string Nome;
        private string Morada;
        public Escola(string N, string M)
        {
            Nome = N;
            Morada = M;
            Console.WriteLine("Instanciei escola: {0}", Nome);
        }
        ~Escola()
        {
            Console.WriteLine("Destrui escola: {0}", Nome);
        }
        public string EscName
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string EscMorada
        {
            get { return Morada; }
            set { Morada = value; }
        }

    }


    public class Aluno:Escola
    {
        private string Nome;
        private int Nota;
        public Aluno(string Escola, string Local, string N, int T1, int T2) : base(Escola, Local)
        {
            Nome = N;
            Nota = (int)((T1 + T2) / 2);
            Console.WriteLine("Instanciei aluno: {0}", Nome);
        }
        ~Aluno()
        {
            Console.WriteLine("Destrui aluno: {0}", Nome);
        }
        public override string ToString()
        {
            return Nome + " da escola " + base.EscName + " ( "+ base.EscMorada +" ) obteve "+ Nota + " Valores";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        string[,] Nomes = { { "Teresa", "ABC" }, { "Anibal", "Rio Tinto"}, { "Rui", " Fancos"},
        {"Victor", "Bolhao" }, {"Joana", "Bom Sucesso"}};
        int[,] Testes = { { 10, 12 }, { 11, 10 }, { 12, 12 }, { 8, 12 }, { 14, 15 } };
        Aluno[] A = new Aluno[5];

        for (int i = 0; i <= A.Length - 1; i++)
            {
                A[i] = new Aluno(Nomes[i, 1], "Porto", Nomes[i, 0], Testes[i, 0], Testes[i, 1]);
                Console.WriteLine(A[i].ToString());
            }
            A = null;
            System.GC.Collect();
            Console.ReadKey();
        }
        
    }
}
