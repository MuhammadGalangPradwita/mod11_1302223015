namespace ProgramMain;
using MatematikaLibraries;


internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Matematika.FPB(60, 45));
            Console.WriteLine(Matematika.KPK(12, 8));
            Console.WriteLine(Matematika.Turunan([1, 4, -12, 9]));
            Console.WriteLine(Matematika.Integral([4,6,-12,9]));
        }
    }

