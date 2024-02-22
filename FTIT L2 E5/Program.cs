List<int> myList = new List<int>();
Console.WriteLine("Cate numere are sirul ?");
int myListCount = int.Parse(Console.ReadLine());
for (int i = 0; i < myListCount; i++)
{
    Console.WriteLine("Introduceti un numar");
    myList.Add(int.Parse(Console.ReadLine()));
}

int sum = 0;
int count = 0;

foreach (int i in myList)
{
    if (i % 2 == 0)
    {
        count++;
        sum += i;
    }
}
Console.WriteLine($"Media aritmetica a numerelor pare este {sum / count}");

/*Ex 5: Să se scrie un program care citeşte de la tastatură un şir de n numere
naturale şi determină media aritmetică a celor pare, n fiind citit de la
tastatra*/
// Nu am stiu sa fac cu un numar de cifre nespecificat inainte in lista. Poate ma lamuriti :).