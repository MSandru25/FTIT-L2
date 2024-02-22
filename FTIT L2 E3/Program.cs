Console.WriteLine("Da-mi un numar");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num != 0)
{
    sum += num % 10;
    num /= 10;
}
Console.WriteLine($"Suma cifrelor acestuia este {sum}");

/*Ex 3: Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
citit de la tastatura.*/
