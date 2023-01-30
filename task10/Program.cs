Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = n/10%10;
Console.Write($"{n2} ");
