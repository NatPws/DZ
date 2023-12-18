// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.


Console.WriteLine("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

{
    int maxNumber = 0;
    int firstNum = number / 10;
    int secondNum = number % 10;
    if (firstNum > secondNum)
    {
        maxNumber = firstNum;
    }
    else
    {
        maxNumber = secondNum;
    }
    Console.WriteLine(maxNumber);
}