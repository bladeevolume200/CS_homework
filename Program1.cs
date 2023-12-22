Console.OutputEncoding = System.Text.Encoding.UTF8;

int dig1 = Convert.ToInt16(Console.ReadLine());
if (dig1 >= 100)
{
    Console.WriteLine("ти тупень");
}
else if (dig1 % 5 == 0 && dig1 % 3 == 0)
{
    Console.WriteLine("fizz buzz");
}
else if (dig1 % 3 == 0)
{
    Console.WriteLine("fizz");
}
else if (dig1 % 5 == 0)
{
    Console.WriteLine("buzz");
}
else
{
    Console.WriteLine(dig1);
}
