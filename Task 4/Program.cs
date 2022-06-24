Console.Write("Input 1 number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2 number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3 number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if (a > b)
{
    max = a;
}
else 
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Max = " + max);