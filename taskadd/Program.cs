Console.Clear();

int n = -1;
int n1 = 0;
int max = 0;

Console.WriteLine("Введите числа : ");

while (n != 0)
{
n = Convert.ToInt32(Console.ReadLine());
if ( n > max ) {
  n1=max; 
  max = n;
} else if (n > n1) n1 = n;

Console.WriteLine($"n={n} max={max} n1={n1}");
}
Console.WriteLine(n1);