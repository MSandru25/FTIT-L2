using System.Linq;

Console.WriteLine("Da-mi un numar");
string num  = Console.ReadLine();
if (num.SequenceEqual(num.Reverse()))
{
    Console.WriteLine("Numarul este palindrom");
}
else
{
    Console.WriteLine("Numarul nu este palindrom");
}

/*Ex 6: Scrieti un program care va determina daca un numar este sau nu
palindrom.*/
//Daca trebuia neaparat rezolvat doar cu for loop, imi pare rau. Va rog sa ma anuntati si refac.