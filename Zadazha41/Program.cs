/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите числа: ");

string[] numsStr = Console.ReadLine().Split(" ");

int m = 0;
for (int i = 0; i < numsStr.Length; i++)
{
    if (Convert.ToInt32(numsStr[i]) > 0) 
    {
        m++;
    }
}
Console.WriteLine($"Вы ввели {m} чисел (числа) больше нуля");
