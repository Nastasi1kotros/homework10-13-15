// Напишите программу, которая ввыводит третью цифру заданного числа или сообщает, что
// третьей цифры нет.

Console.Clear();
Console.Write(" Введите число: ");
int num = int.Parse(Console.ReadLine());
int Length = num.ToString().Length;
if(Length >= 3) {
    while(num > 999){
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine(" Это третья цифра " + result);
}
else
{
    Console.WriteLine(" третьей цифры нет ");
}

