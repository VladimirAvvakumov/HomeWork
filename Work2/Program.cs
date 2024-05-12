// Внутри класса Answer напишите метод CompareNumbers,
//  который на вход принимает два числа и выводит,
//  какое число большее, а какое меньшее.

// пример использования на входе 
// firstNumber = 5
// secondNumber = 6

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber)
{
    Console.WriteLine("числа равны");
}
else
{
    if (firstNumber < secondNumber)
    {
        Console.WriteLine("второе число больше");
    }
    else
    {
        Console.WriteLine("первое число больше");
    }
}
