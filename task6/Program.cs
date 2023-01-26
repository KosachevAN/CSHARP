Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int d = n % 2;
if (d == 0) Console.WriteLine("четное");
else Console.WriteLine("нечетное");