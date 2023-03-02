

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        Program add=new Program();
        int a = 10;
        int b = 20; 
        Console.WriteLine(add.add(a,b));

    }
    public int add(int a,int b)
    {
        int sum = a + b;
        return sum;
    }
}