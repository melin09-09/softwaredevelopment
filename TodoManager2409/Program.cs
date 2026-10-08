using Microsoft.VisualBasic.FileIO;

namespace TodoManager2409
{
    internal class Program
    {
        static List<Zadacha> tasks = new List<Zadacha>();
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("=== ЗАДАЧИ ===");
                Console.WriteLine("1. Добавяне на задача");
                Console.WriteLine("2. Всички въведени задачи");
                Console.WriteLine("3. Избери задача, която да е изпълнена");
                Console.WriteLine("4. Изтрий задачата");
                Console.WriteLine("5. Изход");
                Console.WriteLine("Изберете опция (1-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddTitle();
                        break;

                    case "2":
                        ShowTasks();
                        break;

                    case "3":
                        CompleteTask();
                        break;
                        
                    case "4":
                        DeleteTask();
                        break;

                    case "5":
                        Console.WriteLine("Изход");
                        return;

                    default:
                        Console.WriteLine("Невалиден избор. Моля опитайте отново");
                        break;
                }

            }

        }
        
        static void AddTitle()
        {
            
            Console.WriteLine("--- Добавяне на нова задача ---");
            Console.Write("Въведете заглавие: ");
            string title = Console.ReadLine();
            Console.Write("Въведете описание: ");
            string description = Console.ReadLine();
            Console.Write("Въведете краен срок: ");
            string date = Console.ReadLine();
            //Console.Write("Проверете дали задачата е изпълнена: ");
            bool isCompleted = false;

            Zadacha task = new Zadacha(title, description, date, false);
            tasks.Add(task);
            Console.WriteLine("Задачата е добавена!");
        }

        static void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи");
                return;
            }
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine("Задача " + (i + 1));
                Console.WriteLine("Заглавие: " + tasks[i].Title);
                Console.WriteLine("Описание: " + tasks[i].Description);
                Console.WriteLine("Краен срок: " + tasks[i].Date);

                if (tasks[i].IsCompleted == true)
                {
                    Console.WriteLine("Изпълнена");
                }
                else
                {
                    Console.WriteLine("Не е изпълнена");
                }
            }
        }
        static void CompleteTask()
        {
            ShowTasks();
            if (tasks.Count == 0) return;
            Console.WriteLine("Въведи номер на задачата: ");
            int nomer = int.Parse(Console.ReadLine());

            if(nomer >= 1 && nomer <= tasks.Count)
            {
                tasks[nomer - 1].IsCompleted = true;
                Console.WriteLine("Задачата е изпълнена");
            }
            else
            {
                Console.WriteLine("Няма такава задача");
            }
        }
        static void DeleteTask()
        {
            ShowTasks();
            if(tasks.Count == 0) return;
            Console.Write("Въведи номер на задачата: ");
            int nomer = int.Parse(Console.ReadLine());
            if (nomer >= 1 && nomer <= tasks.Count)
            {
                tasks.RemoveAt(nomer - 1);
                Console.WriteLine("Задачата е изтрита");
            }
            else
            {
                Console.WriteLine("Няма такъв номер");
            }
        }
    }
}
