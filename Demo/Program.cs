

using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        Program add=new Program();
        int a = 10;
        int b = 20; 
        Console.WriteLine(add.add(a,b));
        Program prime=new Program();
        prime.prime();

    }
    public int add(int a,int b)
    {
        int sum = a + b;
        return sum;
    }
    public void prime()
    {
        int rang = 100;
        bool isPrime = true;
        for (int i = 2; i < rang; i++)
        {
            for (int j = 2; j < rang; j++)
            {
                if (i!=j && i%j==0)
                {
                    isPrime = false;
                    break;
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
        }
    }
}