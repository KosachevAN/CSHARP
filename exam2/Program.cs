int A = new Random().Next(1,10);
int B = new Random().Next(1,10);
int C = 0;
if ( A > B ) C = A - B ;
if ( B > A ) C = B - A ;
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine("A - B = C");
Console.WriteLine(C);
