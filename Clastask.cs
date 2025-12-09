int Max(int val1, int val2)
{
    if (val1 > val2) return val1;
    else return val2;
}
int val1, val2;
val1 = Convert.ToInt32(Console.ReadLine());
val2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Max(val1, val2));