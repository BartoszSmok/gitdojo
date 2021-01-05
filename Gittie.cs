using System;

namespace gitdojo
{
    public static class Gittie
    {
        public static void Main(string[] args)
        {
            Introduce();
            Joke();
        }

        public static void Introduce()
        {
            Console.WriteLine("Hello, I'm Gittie!");
        }

        public static void Joke()
        {
            Console.WriteLine("I ate a clock yesterday, it was very time-consuming.");
        }
    }
}