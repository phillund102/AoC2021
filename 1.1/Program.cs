// See https://aka.ms/new-console-template for more information


int input = Int32.Parse(Console.ReadLine());
int input2;
int counter = 0;

while (input != 0)
{
    input2 = Int32.Parse(Console.ReadLine());
    if (input2 > input)
    {
        counter++;
    }
    input = input2;
}

Console.WriteLine(counter); 
