// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.Clear();
Console.Write(" Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
if(day >= 1 && day <= 7) {
    if(day >= 6) {
        Console.WriteLine(" Выходной ");
    }
else
{
    Console.Write(" Рабочий день ");
}
}
else
{
    Console.WriteLine(" Нужно ввести цифру от 1 до 7! ");
}
