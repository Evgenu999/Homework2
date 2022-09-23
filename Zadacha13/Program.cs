Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string anyNumber = Convert.ToString(number);
if (anyNumber.Length > 2){
  Console.WriteLine("Третья цифра этого числа: " + anyNumber[2]);
}
else {
  Console.WriteLine("В этом числе нет третьей цифры ");
}