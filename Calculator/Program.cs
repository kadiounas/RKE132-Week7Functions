Console.WriteLine("Enter the operation (+/-):");
char userOperation = char.Parse(Console.ReadLine());
Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperation)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Substraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operatior");
        break;
}
static void Addition(int a, int b)
{
    Console.WriteLine($"{2} + {b} = {a + b}");
}
static void Substraction(int a, int b)
{
    Console.WriteLine($"{2} - {b} = {a - b}");
}