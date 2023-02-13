Console.WriteLine("Enter the first no");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second no");
int b = Convert.ToInt32(Console.ReadLine());

int c = a;
a = b;
b = c;

Console.WriteLine(a);
Console.WriteLine(b);
