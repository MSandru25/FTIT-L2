Console.WriteLine("Da-mi un numar");
int num = int.Parse(Console.ReadLine());
int res = 1;
for  (int i = 1; i <= num; i++)
{
    res *= i;
}
Console.WriteLine($"Factorialul acestuia este: {res}");

/*Ex 4: Scrieti un program care va afisa factorialul unui numar n, n fiind citit
de la tastatura.*/
