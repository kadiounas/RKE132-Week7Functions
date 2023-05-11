Console.WriteLine("Kas teisendan Fahrenheiti või Celsiusesse (F/C):");
string userInput = Console.ReadLine().ToUpper();
Console.WriteLine("Sisesta väärtus:");
int value = Int32.Parse(Console.ReadLine());

if(userInput =="F")
{
    ConvertToFarenheit(value);

}
else if(userInput == "C")
{
    ConvertToCelsius(value);
}
else
{
    Console.WriteLine("Proovi uuesti!");
}

static void ConvertToCelsius(int Value)
{
    Console.WriteLine($"{(Value - 32) * 5 / 9} kraadi");
}
static void ConvertToFarenheit(int Value)
{
    Console.WriteLine($"{(Value * 9) / 5 + 32} fahrenheiti");
}