// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num/10000);
// Console.WriteLine(num/1000);
// Console.WriteLine(num/100);
// Console.WriteLine(num/10);
// Console.WriteLine(num%10);

    if (Math.Abs(num) > 9999 && Math.Abs(num) < 100000)
    {
        if (num / 10000 == num % 10 && num / 1000 -num/10000*10 == num / 10 - num/100*10) Console.WriteLine($"Число {num} палиндром");
        else Console.WriteLine($"Число {num} не палиндром");
    }
    else Console.WriteLine($"Число {num} не пятизначное");
 
