//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        string number = Console.ReadKey();
        if (number.Length == 5)
        {
            bool isPalindrome = true;

            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Да, это число является палиндромом.");
            }
            else
            {
                Console.WriteLine("Нет, это число не является палиндромом.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Введено непятизначное число.");
        }

        Console.ReadKey();
    }
}
