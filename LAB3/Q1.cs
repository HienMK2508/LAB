

namespace LAB3
{
    internal class Q1
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter two numbers:");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    int num2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine($"Addition: {Calculate<int>(num1, num2, "+")}");
        //    Console.WriteLine($"Subtraction: {Calculate<int>(num1, num2, "-")}");
        //    Console.WriteLine($"Multiplication: {Calculate<int>(num1, num2, "*")}");
        //    Console.WriteLine($"Division: {Calculate<double>(num1, num2, "/")}");

        //    Console.ReadLine();
        //}

        static T Calculate<T>(T num1, T num2, string operation)
        {
            dynamic a = num1;
            dynamic b = num2;

            switch (operation)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }
}