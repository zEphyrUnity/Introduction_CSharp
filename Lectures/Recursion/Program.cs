double Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}

for(int i = 1; i < 30; i++)
{
    Console.WriteLine(Factorial(i));
}
