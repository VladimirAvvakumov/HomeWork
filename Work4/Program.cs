// Внутри класса Answer напишите метод CheckIfEven,
//  который на вход принимает число number и выводит,
//   является ли число чётным (делится ли оно на два без остатка).

// Пример использования:
// На входе:'6'


Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("число являеться четным");
}
else
{
    Console.WriteLine("Число не являеться четным");
}