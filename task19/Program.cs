Console.Clear();
Console.WriteLine("Введите палиндром: ");
int n = Convert.ToInt32((Console.ReadLine()));
int i, p=0, r = 0; 
for (i = n; i > 0; i = (i / 10))
    {
        r = i % 10;
        p = p*10 + r;
        //Console.WriteLine($"r={r} i={i} p={p}");
    }
Console.WriteLine($"{n == p}"); 


