namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //===== 1 zadaca =====
            Console.Write("Възраст: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                 Console.WriteLine("Невалидна възраст.");
                Console.Write("Въведете възраст: ");
            }  
            Console.WriteLine($"Въведете възраст: {age}"); 

            //===== 2 zadaca =====
            Console.Write("Клас на ученика: ");
            if (byte.TryParse(Console.ReadLine(), out byte clas))
            {
                Console.WriteLine($"Клас: {clas}");
            }
            else
            {
                Console.WriteLine("Невалиден клас.");
            }

            //===== 3 zadaca =====
            Console.Write("Въведете среден успех: ");
            if (double.TryParse(Console.ReadLine(), out double d))
            {
                Console.WriteLine($"Средният успех е: {d}");
            }
            else
            {
                Console.WriteLine("Няма такъв успех!");
            }

            //===== 4 zadaca =====
            Console.Write("Въведете парична стойност: ");
            if(decimal.TryParse(Console.ReadLine(), out decimal money))
            {
                Console.WriteLine($"Стойността е: {money}");
            }

            //===== 5 zadaca =====
            Console.Write("Въведете: ");
            if (bool.TryParse(Console.ReadLine(), out bool hasScholarship))
            {
                Console.WriteLine(hasScholarship);
            }

            //===== 6 задача ===== 
            Console.Write("Въведете буква на паралелката: ");
            if (char.TryParse(Console.ReadLine(), out char ch))
            {
                Console.WriteLine($"Паралелка: {ch}");
            }
            else
            {
                Console.WriteLine("Грешно!");
            }

            //===== 7 задача =====
            Console.Write("Въведете дата на раждане: ");
            while (true)
            {
                Console.Write("Дата на раждане: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                {
                    break;
                }
                Console.WriteLine("Невалидна дата.");

            }
                

        }
    }
}
