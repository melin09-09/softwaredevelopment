namespace StudentHomework
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private int grade;
        private double averageScore;
        private decimal fee;
        private bool hasScholarship;
        private char classLetter;
        private DateTime birthDate;

        public int Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public double AverageScore { get; set; }
        public decimal Fee { get; set; }
        public bool HasScholarship { get; set; }
        public char ClassLetter { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(int id, string name, int age, int grade, double averageScore, decimal fee, bool hasScholarship, char classLetter, DateTime birthDate)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("id");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Името не може да е празно");
            }
            if (age < 6 || age > 20)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(age),
                    "Възрастта трябва да бъде между 6 и 20 години.");
            }
            if (grade < 1 || grade > 12)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(grade),
                    "Класът трябва да е между 1 и 12.");
            }
            if (averageScore < 2.00 || averageScore > 6.00)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(averageScore),
                    "Средният успех трябва да е между 2.00 и 6.00");
            }
            if (fee < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(fee),
                    "Таксата не може да бъде отрицателна.");
            }
            if (!char.IsLetter(classLetter))
            {
                throw new ArgumentException(
                    nameof(classLetter),
                    "Паралелката трябва да е буква.");
            }
            if (birthDate > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(birthDate),
                    "Дата на раждане не може да е бъдеща дата.");
            }

            Id = id;
            Name = name;
            Age = age;
            Grade = grade;
            AverageScore = averageScore;
            Fee = fee;
            HasScholarship = hasScholarship;
            ClassLetter = classLetter;
            BirthDate = birthDate;

        }
    }
    internal class Program
    {
        private static List<Student> students = new List<Student>();
        private static int nextId = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=== ДАННИ ЗА УЧЕНИК ===");
                int id = nextId;
                Console.WriteLine("Id: " + id);
                try
                {
                    Console.Write("Име: ");
                    string name = Console.ReadLine();

                    Console.Write("Възраст: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Клас: ");
                    int grade = int.Parse(Console.ReadLine());

                    Console.Write("Среден успех: ");
                    double averageScore = double.Parse(Console.ReadLine());

                    Console.Write("Такса: ");
                    decimal fee = decimal.Parse(Console.ReadLine());

                    Console.Write("Стипендия: ");
                    bool hasScholarship = bool.Parse(Console.ReadLine());

                    Console.Write("Паралелка: ");
                    char classLetter = char.Parse(Console.ReadLine());

                    Console.Write("Дата на раждане: ");
                    DateTime birthDate = DateTime.Parse(Console.ReadLine());

                    Student student = new Student(id, name, age, grade, averageScore, fee, hasScholarship, classLetter, birthDate);
                    students.Add(student);
                    nextId++;

                    Console.WriteLine("Ученикът е добавен");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Грешка: " + ex.Message);
                    Console.WriteLine("Опитай да въведеш данните отново");
                }
            }
        }
    }
}
