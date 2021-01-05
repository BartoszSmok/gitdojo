using System;

namespace gitdojo
{
    public static class Gittie
    {
        public static void Main(string[] args)
        {
            Introduce();
            Console.WriteLine(add(2,4));
            Joke();
        }

        public static void Introduce()
        {
            Console.WriteLine("Hello, I'm Gittie! i dont like git");
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static void Joke()
        {
            Console.WriteLine("I ate a clock yesterday, it was very time-consuming.");
        }
    }
}