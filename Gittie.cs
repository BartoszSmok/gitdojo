using System;

namespace gitdojo
{
    public static class Gittie
    {
        public static void Main(string[] args)
        {
            Introduce();
            Console.WriteLine(add(2,4));
        }

        public static void Introduce()
        {
            Console.WriteLine("Hello, I'm Gittie!");
        }

        public static int add(int a, int b)
        {
            return a + b;
        }
    }
}