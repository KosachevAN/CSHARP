Console.Clear();

Console.Write("Введите день недели: ");
int d = Convert.ToInt32(Console.ReadLine());

if ((d == 6) || (d == 7)) 
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");