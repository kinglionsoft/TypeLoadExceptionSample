using System;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = typeof(EfRepositoryBase<,>);
            // or
            // typeof(Class1).Assembly.DefinedTypes.ToList();
            Console.WriteLine("Hello World!");
        }
    }
}
