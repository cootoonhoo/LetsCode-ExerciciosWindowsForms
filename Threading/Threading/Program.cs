using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ExercicoThread
{
    class Program
    {
        static void Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            int QntDeThreads = 0;
            bool teste;
            do
            {
                Console.WriteLine("Digite a quantidade de threads que deseja");
                teste = int.TryParse(Console.ReadLine(), out QntDeThreads) && QntDeThreads > 0;
                if (!teste) Console.WriteLine("Valor inválido");
            } while (!teste);
            Console.WriteLine("Rodando...");
            RodarTask(QntDeThreads);
            sw.Stop();
            Console.WriteLine($"Foram gastos {sw.Elapsed}");
        }
        static void AcertarBaseDeDados()
        {
            Thread.Sleep(4000);
        }
        static void EnviarEmail()
        {
            Thread.Sleep(4000);
        }
        static void LimparArquivosTemporarios()
        {
            Thread.Sleep(4000);
        }
        static void RodarTask(int numThreads)
        {
            Parallel.Invoke(new ParallelOptions { MaxDegreeOfParallelism = numThreads },
                new Action(AcertarBaseDeDados), new Action(EnviarEmail), new Action(LimparArquivosTemporarios)
                );
        }
    }
}