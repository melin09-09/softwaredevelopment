namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Възраст: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Възраст: {age}"); 
            }  
            else
            {
                Console.WriteLine("Невалидна възраст."); 
            }
        }
    }
}
