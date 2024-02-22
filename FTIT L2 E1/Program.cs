Console.WriteLine("x =");
int x = Convert.ToInt32(Console.ReadLine());
int res = 0;
if (x <= -2)
{
    res = (x * x) * 7;
    Console.WriteLine(res);
}
else if (x > -2 && x <= 0.5)
{
    res = 4 * x - 5;
    Console.WriteLine(res);
}
else if (x > 0.5)
{
    res = 14 * x - 7;
    Console.WriteLine(res);
}

/*Ex 1: Scrieti un program care va calcula valoarea urmatoarei functii pentru
x citit de la tastatura*/
