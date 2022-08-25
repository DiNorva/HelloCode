
static int Factorial(int n)
{
    Console.WriteLine(n);
    if(n == 1) return 1;
    return n * Factorial(n-1);
}
Console.WriteLine(Factorial(3));