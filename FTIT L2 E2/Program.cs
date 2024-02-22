Console.WriteLine("Da-mi un numar negativ");
int num = int.Parse(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("Numarul nu este negativ");
}
else if (num % 2 == 0 ^ num % 6 == 0)
{
    Console.WriteLine("Numarul este divizibil cu 2 si nu este divizibil cu 6");
}
else
{
    Console.WriteLine("Numarul este divizibil cu 2 si cu 6");
}

/*Ex 2: Scrieti un program care va determina daca un numar negativ citit de
la tastatura este divizibil cu 2 si nu este divizibil cu 6*/