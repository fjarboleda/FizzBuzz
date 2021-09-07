using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzy = new DictionaryFizzBuzz();
           
            for(int i=1;i<=100;++i)
            {
                Console.WriteLine($"{i} -> f({fizzy.FizzBuzz((sbyte)i)})");    
            }
            
        }
    }
}
