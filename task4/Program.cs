﻿// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
{
    if (N < 10)
    {
        Console.WriteLine(N);
    }
    else
    {
        while (N > 0)
        {
            int number = N % 10; 
            N /= 10;
            if (N > 0)
            {
                Console.Write(number + ",");
            }
            else
            {
                Console.WriteLine(number);
            }
        }        
    }
}
