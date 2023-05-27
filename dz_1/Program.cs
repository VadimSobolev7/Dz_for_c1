//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());    
int Length = number.ToString().Length;                         //Преобразуем из одного формата в другой

if (Length == 3)
{
    int result = (number/10) % 10;
    Console.WriteLine("Вторая цифра числа:" + result);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");    
}