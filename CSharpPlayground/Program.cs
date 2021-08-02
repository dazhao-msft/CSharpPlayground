using System;

namespace CSharpPlayground
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person() { FirstName = "David", LastName = "Zhao" };

            Console.WriteLine(person);
        }
    }

    public record Person
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }
    }
}
