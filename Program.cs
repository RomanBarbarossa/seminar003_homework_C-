// Задача 19: Напишите программу, которая принимает на вход пятизначное
//  число и проверяет, является ли оно палиндромом.

// Console.Write("Введите пятизначное число:  ");
// string number = Console.ReadLine()!;
// if(number.Length < 5 || number.Length > 5)
// {
//     Console.WriteLine("Ошибка! Вы ввели не верное число");
// }
// else if(number[0] == number[4] || number[1] == number[3])
// {
//     Console.WriteLine($"Заданное число {number} является палиндромом");
// }
// else
//     {
//         Console.WriteLine($"Заданное число {number} НЕ является палиндромом");
//     }

// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("Введите координату X1 для первой точки: ");
// double x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y1 для первой точки: ");
// double y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Z1 для первой точки: ");
// double z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату X2 для первой точки: ");
// double x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y2 для первой точки: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Z2 для первой точки: ");
// double z2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2)),3);
// Console.WriteLine($"Расстояние между точками равно {result}");





// // Задача 23: Напишите программу, которая принимает на вход число (N)
// //  и выдаёт таблицу кубов чисел от 1 до N

Console.Write("Введите число ->  ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n ; i++)
{
    Console.Write(Math.Pow(i,3)+ ", ");
}



