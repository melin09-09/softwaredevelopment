namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало на програмата");

            Console.Write("Въведете число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Въведохте: {number}");

            Console.WriteLine("Край на програмата");
        }
    }
}
