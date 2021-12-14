using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var humans = new HumanRD("", "", 0, 0);

            for (int j = 0; j < humans.arr.Length; j++)
            {
                Console.Write("Введiть прiзвище: ");
                string surname = Console.ReadLine();
                Console.Write("Введiть iнiцiали: ");
                string initials = Console.ReadLine();
                Console.Write("Введiть рiк народження: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введiть оклад: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                humans.arr[j] = new HumanRD(surname, initials, year, salary);
            }

            HumanRD.count--;

            void OldestMan()
            {
                int y = int.MaxValue;
                for (int i = 0; i < humans.arr.Length; i++)
                {

                    if (humans.arr[i].year < y)
                        y = humans.arr[i].year;

                }
                Console.WriteLine("Найстаршому працiвнику " + Math.Abs(y - 2021) + " рокiв\n");
            }

            Console.WriteLine("Об'єкти: " + (HumanRD.count) + "\n");
            OldestMan();
            if (HumanRD.count < 3)
                Console.WriteLine("Об'єктiв менше нiж в таблицi");
            else if (HumanRD.count == 3)
                Console.WriteLine("Об'єктiв рiвно скiльки в таблицi");
            else if (HumanRD.count > 3)
                Console.WriteLine("Об'єктiв бiльше нiж в таблицi");
        }
    }

    class HumanRD
    {
        public HumanRD[] arr = new HumanRD[9];
        public static int count = 0;
        public string initials;
        public string surname;
        public int year;
        public double salary;
        public HumanRD(string surname, string initials, int year, double salary)
        {
            this.initials = initials;
            this.surname = surname;
            this.year = year;
            this.salary = salary;
            count++;
        }
    }
}
