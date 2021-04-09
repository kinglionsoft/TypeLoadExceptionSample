using System;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = typeof(EfRepositoryBase<,>);
            // or
            // typeof(Program).Assembly.DefinedTypes.ToList();
            /*
             *  System.TypeLoadException:
             *     Method 'Max' in type 'ConsoleSample.EfRepositoryBase`2'
             *     from assembly 'ConsoleSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
             *     does not have an implementation.
             */
            Console.WriteLine("Hello World!");
        }
    }
}
