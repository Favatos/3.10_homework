using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 1
Напишите метод, который отображает квадрат из некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.
Задание 2
Напишите метод, который проверяет является ли переданное число «палиндромом». Число передаётся в качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
Палиндром — число, которое читается одинаково как справа налево, так и слева направо. Например:
1221 — палиндром;
3443 — палиндром;
7854 — не палиндром.
Задание 3
Напишите метод, фильтрующий массив на основании переданных параметров. Метод принимает параметры:
оригинальный_массив, массив_с_данными_для_фильтрации.
Метод возвращает оригинальный массив без элемен-
тов, которые есть в массиве для фильтрации.
Например:
1 2 6 - 1 88 7 6 — оригинальный массив;
6 88 7 — массив для фильтрации;
1 2 - 1 — результат работы метода.*/
namespace _3._10_дз
{
    class Class
    {
        //1
        static public void printSquare(int lenght, string simbol)
        {
            for (int i = 0; i < lenght; i++)
            {
                for(int j = 0; j < lenght; j++)
                {
                    Console.Write(simbol + ' ');
                }
                Console.WriteLine();
            }
        }
        //2
        static public bool isPalindrome(int num)
        {
            int dig = 0;
            int rev = 0;
            int n = num;

            while (num > 0)
            {
                dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }

            if (n == rev){
                return true;
            }
            else
            {
                return false;
            }
        }
        //3
        static public int[] Filter(int[] arr1, int[] arr2)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                arr1 = Array.FindAll(arr1, num => num != arr2[j]).ToArray();
            }

            return arr1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class.printSquare(5, "*");
            Console.WriteLine(Class.isPalindrome(121));

            int[] arr1 = { 1, 2, 6, -1, 88, 7, 6 };
            int[] arr2 = { 6, 88, 7 };

            arr1 = Class.Filter(arr1, arr2);

            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
