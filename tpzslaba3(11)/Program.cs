/*I.Завдання з даного пункту вирішити, використовуючи одномірний масив.
1. Дана послідовність з n дійсних чисел.Підрахувати кількість максимальних елементів.
2. Підрахувати суму елементів, розташованих між першим максимальним і останнім мінімальними елементами.
3. Знайти мінімум з позитивних елементів.*/

using System;

namespace tpzslaba3_11_
{
    class Program
    {
        static int[] Input()
        {
            Console.WriteLine("Введите размерность массива:  ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;

        }
        static int Max(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; ++i)
                if (a[i] > max) max = a[i];
            return max;
        }
        static int Min(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; ++i)
                if (a[i] < min) min = a[i];
            return min;
        }
        static void MP()
        {
            int n = 10, min = 100;
            int[] mass = new int[n];

            Console.WriteLine("Введите ваш массив (10 элементов)");
            for (int i = 0; i < n; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " \t");
            }
            // min = mass[0];
            for (int i = 0; i < n; i++)
            {

                if (mass[i] > 0 && min > mass[i])
                {
                    min = mass[i];
                }


            }
            Console.Write("\n");
            Console.WriteLine("Минимальный элемент из положительных:  " + min);
        }
        static void Main()
        {
            //int M = 0;
            //int m = 0;
            //int[] myArray = Input();
            //int max = Max(myArray);
            //int min = Min(myArray);
            //int kol = 0;
            /*for (int i = 0; i < myArray.Length; ++i)
                if (myArray[i] == max) ++kol;
            Console.WriteLine("Количество максимальных элементов = " + kol);
            for (int i = 0; i < myArray.Length; ++i)
                if (myArray[i] == max && M == 0)
                    M = i;
            for (int i = 0; i < myArray.Length; ++i)
            {
                if (myArray[i] == min) m = i;
            }
            Console.WriteLine(" Количество между первым максимальны и последним минимальным : " + ((Math.Abs(m - M) - 1)));*/
             MP();


            Console.Read();
        }


    }
}
