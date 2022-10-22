using System;

namespace LabWork8_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N вступительных экзаменов"); //вывод на консоль
            int n = int.Parse(Console.ReadLine()); //ввод и задание переменной целочисленного типа
            Console.WriteLine("Введите M абитуриентов"); //вывод на консоль
            int m = int.Parse(Console.ReadLine());//ввод и задание переменной целочисленного типа
            double[][] marks = new double[m][]; //вещественный массив
            int count = 0; //задание переменной целочисленного типа

            for (int i = 0; i < m; i++) //выполнение действий пока верно указанное условие
            {
                marks[i] = new double[n]; //задание вещественного массива
                for (int j = 0; j < n; j++) //выполнение действий пока верно указанное условие
                {
                    marks[i][j] = new Random().Next(6); //задание вещественного массива

                    if (marks[i][j] == 5) //проверка выполнения условия
                        count++; //инкремент
                }

            }
            Console.WriteLine($"Количество абитуриентов, которые сдали на отлично = {count}"); //вывод на консоль
        }
    }
}
