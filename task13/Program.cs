Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
String str = num.ToString();
String err = "третьей цифры нет";

if (str.Length > 2) 
    Console.WriteLine(str[2]);
else
    Console.WriteLine(err); 
    
 

