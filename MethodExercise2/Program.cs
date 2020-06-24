using System;

namespace MethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello - what is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"How old are you?");
            var userAge = Console.ReadLine();

            Console.WriteLine($"What is your favorite animal?");
            var favAnimal = Console.ReadLine();

            Console.WriteLine($"What is your favorite band?");
            var favBand = Console.ReadLine();

            Console.WriteLine($"My name is {userName} and I am {userAge}.");
            Console.WriteLine($"My favorite animal is {favAnimal}, and I like to listen to {favBand}.");
        }
    }
}
