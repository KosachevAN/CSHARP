Console.Clear();

Console.Write("Введите число 1: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int l = Convert.ToInt32(Console.ReadLine());

if (m > max) max = m;
if (l > max) max = l;
    
Console.WriteLine($"Максимальное число = {max}");
