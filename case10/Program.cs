// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру
// этого числа.

Console.Clear();
Console.Write(" Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int Length = num.ToString().Length;
if(Length == 3) {
    int result = (num / 10) % 10;
    Console.WriteLine(" Вторая цифра " + result);
}
else
{
    Console.WriteLine(" Это не трехзначное число ");
}
