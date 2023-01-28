// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int z = num / 10;
int count = 0;
int d = num;
if (z != 0)
{
    while (d != 0)
    {
        d = d / 10;
        count++;
    }
    Console.WriteLine($"В числе {count} порядка/ов");
}
else
{
    Console.WriteLine($"В числе один порядок. Сумма цифр в числе равно самому числу.");
}
int[] array = new int[count];
int b = num;
for (int i = 0; i < count; i++)
{
    int a = b % 10;
    array[i] = a;
    b = b / 10;
    Console.Write($"{array[i]} ");
}
int sum = 0; 
for (int j = 0; j < count; j++)
{
    sum = sum + array[j]; 
}
Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе равно {sum}");

