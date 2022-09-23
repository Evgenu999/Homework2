// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да 7 -> да 1 -> нет

Console.WriteLine("Ввведите цифру от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
void Week(int number)
{
    if (number > 7 || number < 0)
    {
        Console.WriteLine("Неверно укзали цыфру дня недели ");
    }
    if (number == 1)
    {
        Console.WriteLine("Это понедельник - рабочий день! ");
    }
    if (number == 2)
    {
        Console.WriteLine("Это вторник - рабочий день! ");
    }
    if (number == 3)
    {
        Console.WriteLine("Это среда - рабочий день! ");
    }
    if (number == 4)
    {
        Console.WriteLine("Это четверг - рабочий день! ");
    }
    if (number == 5)
    {
        Console.WriteLine("Это пятница - рабочий день! ");
    }
    if (number == 6)
    {
        Console.WriteLine("Это суббота - является выходным днем! ");
    }
    if (number == 7)
    {
        Console.WriteLine("Это воскресение - является выходным днем! ");
    }
}
Week(number);

// расписал подробно, мог написать в соответствии с примерами ответов по этой задаче