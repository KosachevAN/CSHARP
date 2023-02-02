Console.Clear();
Console.Write("Введите число : ");
int n = Convert.ToInt32((Console.ReadLine()));
int s = 0, i = 0;
for (i = 1 ; i<=n; i++ ) {
    s = i*i*i;
    Console.WriteLine(s);
}
