Console.WriteLine("x =");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("y =");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("z =");
int z = int.Parse(Console.ReadLine());

int aux = 0;

if (x < y)
{
    aux = x;
    x = y;
    y = aux;
}
if (x < z)
{
    aux = x;
    x = z;
    z = aux;
}
if (y < z)
{
    aux = y;
    y = z;
    z = aux;
}

Console.WriteLine($"Numerele ordonate descrescator sunt:\n{x}, {y}, {z}");

