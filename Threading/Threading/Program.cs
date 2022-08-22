using System.Threading;
using System.Diagnostics;

namespace ExercicoThread {
    class Program {
        static Thread[] Threads = new Thread[7];
        static void Main() {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < Threads.Length; i++) {
                Threads[i] = new Thread(new ThreadStart(TaskExecute));
                Threads[i].Start();
            }
        foreach(var t in Threads){
                t.Join();
            }
            sw.Stop();
            Console.WriteLine($"O tempo gasto foi de {sw.Elapsed}");
        }

        static void ApiCall() {
            Thread.Sleep(2000);
        }
        static void TaskExecute() {
            for (int i = 0; i < 100; i++) {
                ApiCall();
            }
        }
    }
}