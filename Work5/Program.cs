// Внутри класса Answer напишите метод PrintEvenNumbers,
//  которая на вход принимает число (number),
//   а на выходе выводит все чётные числа от 1 до number (включительно), 
//   после каждого числа должен быть знак пробела.

// На входе:
// number = 5 


Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count < number)
{
    count = count + 1;
    Console.Write(count + " ");
    count = count + 1;
}


