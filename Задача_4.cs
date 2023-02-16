int a = 100, b = 213, c = 93;
int max = a;
if (max < b)
{
    max = b;
    if (max < c)
    {
        max = c;
    }
}
Console.Write("max = " + max);