// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("Квадрат числа " + num + " равен: " + result);


// Console.Write("Введите первое число ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// if (firstNum == secondNum * secondNum)
// {
//     Console.WriteLine("Число " + firstNum + " является Квадратом числа " + secondNum);
// }
// else
// {
//     Console.WriteLine("Число " + firstNum + " Не является Квадратом числа " + secondNum);
// }


// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num < 0 )
// {
//     num = num * (-1);
// }
// int negative = num * (-1);
// while(negative <= num)
// {
//     Console.Write(negative + " ");
//     negative++;
// }
// Console.WriteLine();


// Задача 2 Напишите программу, 
// которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.Write("Введите число №1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число №2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 )
// {
//     Console.WriteLine(num1 + " - больше, чем число " + num2);
// }
// else
// {
//     Console.WriteLine(num2 + " - больше, чем число " + num1);
// }


// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.Write("Введите число №1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число №2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число №3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int numMax;
// if(num1 > num2)
// {
//     numMax = num1;
// }
// else
// {
//     numMax = num2;
// }
// if(numMax < num3)
// {
//     numMax = num3;
// }
// Console.WriteLine("Максимально число из данных - " + numMax);



// Задача 6: Напишите программу,
//  которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число №1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2;
// num2 = num1 % 2;
// if(num2 > 0)
// {
//     Console.WriteLine("Введеное число нечетное");
// }
// else
// {
//      Console.WriteLine("Введеное число четное");
// }



// Задача 8: Напишите программу,
// которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 2;
Console.Write(num2 + " ");
while(num2 < num1 - 1)
{
    num2 = num2 + 2;
    Console.Write(num2 + " ");    
}
// Этот код как то работает!!! наверное это не то решение которое должно быть идеальным,
// но оно работает. Через if и else (внутри цикала), никак не получалось.
//  (error CS8641: "else" не может запускать оператор.) 
// Хотя задачка выше if и else прекрасно работают, почему то внутри цика
// вылетает эта шибка.