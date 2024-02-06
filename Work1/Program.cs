using System;
using System.Net.Http.Headers;

namespace Work1
{
    // Assignment1
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            string name = "Antii";
            int playerScore = 1000;
            int levelScore = 50;

            Console.WriteLine($"{name} has score before level: {playerScore}");
            Console.WriteLine($"{name} has score after level: {playerScore + levelScore}");
        }
    }

    //// Assignment2
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            float x = 10.5f;
            float y = 20f;
            float multiplier = 0.5f;

            Console.WriteLine($"x : {x} y : {y}");
            Console.WriteLine($"Multiplier : {multiplier}");
            Console.WriteLine($"Devided x : {x * multiplier} y : {y * multiplier}");
        }
    }

    // Assignment3
    internal class Assignment3
    {
        static void Main(string[] args)
        {
            string name = "Margarita";
            int age = 17;
            string home = "St. Petersburg";
            string color = "white";
            bool lovesRock = false;

            Console.WriteLine($"Hello! My name is {name}. I'm {age} years old.\nI'm from {home}. " +
                $"My favourite color  is {color}. I likes rock:{lovesRock}");

        }
    }

    // Assignment4
    internal class Assignment4
    {
        static void Main(string[] args)
        {
            string name = "Margarita";
            string lastName = "Nyman";
            name += " " + lastName;
            Console.WriteLine($"{name}");

        }
    }

    // Assignment5
    internal class Assignment5
    {
        static void Main(string[] args)
        {
            string name = "Margarita";
            string lastName = "Nyman";
            name += " " + lastName;
            int order = 3;

            Console.WriteLine($"{name} the {order}rd");

        }
    }


}
