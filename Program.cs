//Console.WriteLine("Nome: ");
//string? nome = Console.ReadLine();
//Console.WriteLine($"Your name is >>> {nome}"); //<-- Similar to a Python 'f' string

class Program()
{
    static void Main()
    {
        Console.WriteLine("--- Calculator ---");
        Console.WriteLine("Insert Number");
        Console.WriteLine("User : ");
        string? User = Console.ReadLine();
        int input1 = Convert.ToInt32(User);
        //Another input
        Console.WriteLine("Insert Number");
        Console.WriteLine("User : ");
        User = Console.ReadLine();
        int input2 = Convert.ToInt32(User);
        //Final Result
        Console.WriteLine("--- Final Result ---");
        Console.WriteLine($"Adition: {input1 + input2}");
        Console.WriteLine($"Subtraction: {input1 - input2}");
        Console.WriteLine($"Multiplication: {input1 * input2}");

        if (input2 != 0)
        {
            Console.WriteLine($"Division: {(double)input1 / input2}");
        }
        else
        {
            Console.WriteLine("Division: It is not possible to divide by Zero");
        }
    }
}