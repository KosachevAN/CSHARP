Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n = -1;
int d = 1;
int l = 0;
int res = 0;

num = num / 1000;

while (n != 0) {
    d = d * 10;
    n = num / d;
    l++;
//Console.WriteLine($"l={l} d={d} n={n} " );
}
d = d / 100;
Console.WriteLine(d);
if ( l>2 ) {
    res = num % d;   
    Console.WriteLine(res);
    d = d / 10;
    res = res / d;    
    //res = Convert.ToInt32(num % Math.Pow(10, l-2) / Math.Pow(10, l-3));
    Console.WriteLine(res);
} else
    Console.WriteLine("третьей цифры нет");

