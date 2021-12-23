using System;
using System.Linq;

namespace _7._3
{
    class Program
    {
        //7.3, 2-й вариант, высокий уровень, Гребенюк А. 21-ИСП-2
        public struct STUDENT
        {
            public string name;
            public int kurs;
            public int[] SES;
        }
        static void Main(string[] args)
        {
            double summclass = 0;
            STUDENT[] STUD = new STUDENT[10];
            for (int i = 0; i < STUD.Length; i++)
            {
                STUD[i].SES = new int[5];
                Console.WriteLine("Введите имя и инициалы: ");
                STUD[i].name = Console.ReadLine();
                Console.WriteLine("Введите курс: ");
                STUD[i].kurs = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценки через Enter: ");
                for (int j = 0; j < 5; j++)
                {
                    STUD[i].SES[j] = int.Parse(Console.ReadLine());
                }
                int summ = 0;
                for (int s = 0; s < 5; s++)
                {
                    summ += STUD[i].SES[s];
                }
                summclass += summ;
            }
            STUD = STUD.OrderBy(STUDENT => STUDENT.name).ToArray();
            for (int i = 0; i < STUD.Length; i++)
            {
                int summ = 0;
                for(int j = 0; j < 5; j++)
                {
                    summ += STUD[i].SES[j];
                }
                double sred = summ / 5;
                if (sred > (summclass/10/5))
                {
                    string ocen = "";
                    foreach (int item in STUD[i].SES)
                    {
                        Convert.ToString(item);
                        ocen = ocen + item + " ";
                    }
                    Console.WriteLine("Лучшие студенты: ");
                    string horosh = STUD[i].name + ", " + STUD[i].kurs + "-й Курс, Оценки: " + ocen;
                    Console.WriteLine(horosh);
                }
            }
        }
    }
}
