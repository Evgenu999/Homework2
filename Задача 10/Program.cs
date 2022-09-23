// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число ");

int number = int.Parse(Console.ReadLine());

void Live()
{
int number_1 = number / 10;
int number_2 = number_1 % 10;
if (number>999 || number < 100) 
{
    Console.WriteLine("Неверно указано число ");
}
else
{
    Console.WriteLine($"Вторая цифра этого числа: {number_2}");
}
}
Live();

// написал при помощи метода, а изначально делал "без" в очень простом и рабочем виде