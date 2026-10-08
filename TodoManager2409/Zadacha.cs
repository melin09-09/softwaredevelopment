using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager2409
{
    internal class Zadacha
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date {  get; set; }
        public bool IsCompleted { get; set; } 

        public Zadacha(string title, string description, string date, bool isCompleted)
        {
            Title = title;
            Description = description;
            Date = date;
            IsCompleted = isCompleted;
        }

        public void PrintTasks()
        {
            if (IsCompleted == true)
            {
                Console.Write("Zaglavie: " + Title +  "Opisanie: " + Description + "Kraen srok: " + Date);
            }
            else
            {
                Console.Write("Zaglavie: " + Title + "Opisanie: " + Description + "Kraen srok: " + Date + "Статус: не е изпълнена ");
            }
            
        }
    }
}
