// Напишите программу, 
// которая принимает на вход трёхзначное
//  число и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81


Console.WriteLine("Введите положительное трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num >=100 && num <= 999)
{
    int firstDigit = num / 100; // 256 / 100 = 2.56
    int thirdDigit = num % 10; // 256 % 10 = 250 + 6 = 6

    int result = firstDigit * 10 + thirdDigit;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("некоректный ввод");
}
