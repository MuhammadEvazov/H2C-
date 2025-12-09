// Homework2

// // Task1
// int n, even = 0, odd = 0, digit = 0, sum = 0;
// n = Convert.ToInt32(Console.ReadLine());
// for (int i = n; i > 0; i /= 10)
// {
//     if ((i % 10) % 2 == 0)
//     {
//         even++;
//     }
//     else
//     {
//         odd++;
//     }
// }
// for (int i = n; i > 0; i /= 10)
// {
//     sum = sum + i % 10;
//     digit++;
// }
// Console.WriteLine($"Even: {even}");
// Console.WriteLine($"Odd: {odd}");
// Console.WriteLine($"Digit: {digit}");
// Console.WriteLine($"Sum: {sum}");

// // Task2
// int a, b;
// a = Convert.ToInt32(Console.ReadLine());
// b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Add: {a + b}");
// Console.WriteLine($"Substract: {a - b}");
// Console.WriteLine($"Multiply: {a * b}");
// Console.WriteLine($"Division: {a / b}");

// // Task3
// int MinDigit(int n)
// {
//     int min = 999;
//     for (int i = n; i > 0; i /= 10)
//     {
//         if (i % 10 < min)
//         {
//             min = i % 10;
//         }
//     }
//     return min;
// }
// int Maxdigit(int n)
// {
//     int max = -999;
//     for (int i = n; i > 0; i /= 10)
//     {
//         if (i % 10 > max)
//         {
//             max = i % 10;
//         }
//     }
//     return max;
// }
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{MinDigit(n)} + {Maxdigit(n)} = {MinDigit(n) + Maxdigit(n)}");

// // Task4
// double Pow(int x, int y)
// {
//     double pow = Math.Pow(x, y);
//     return pow;
// }
// int x, y;
// x = Convert.ToInt32(Console.ReadLine());
// y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Pow(x, y));

// // Task5
// void Swap(ref int a, ref int b)
// {
//     int c = a;
//     a = b;
//     b = c;
// }
// int x, y;
// x = Convert.ToInt32(Console.ReadLine());
// y = Convert.ToInt32(Console.ReadLine());

// Swap(ref x, ref y);

// Console.WriteLine($"x = {x}");
// Console.WriteLine($"y = {y}");

// // Task6
// void Divisors(int x)
// {
//     for (int i = 1; i <= x; i++)
//     {
//         if (x % i == 0)
//         {
//             Console.Write(i + " ");
//         }
//     }
// }
// int x;
// x = Convert.ToInt32(Console.ReadLine());
// Divisors(x);

// Task7



// // Task8
// int MinNumber(int a, int b, int c, int d)
// {
//     if (a < b && a < c && a < d) return a;
//     else if ( b < a && b < c && b < d) return b;
//     else if (c < a && c < b && c < d) return c;
//     else return d;
// }
// int a, b, c, d;
// a = Convert.ToInt32(Console.ReadLine());
// b = Convert.ToInt32(Console.ReadLine());
// c = Convert.ToInt32(Console.ReadLine());
// d = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(MinNumber(a, b, c, d));

// // Task9
// int Min(int val1, int val2)
// {
//     if (val1 < val2) return val1;
//     else return val2;
// }
// int val1, val2;
// val1 = Convert.ToInt32(Console.ReadLine());
// val2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Min(val1, val2));

// // Task10
// int Max(int val1, int val2)
// {
//     if (val1 > val2) return val1;
//     else return val2;
// }
// int val1, val2;
// val1 = Convert.ToInt32(Console.ReadLine());
// val2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Max(val1, val2));