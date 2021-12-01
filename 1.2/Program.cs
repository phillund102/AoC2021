// See https://aka.ms/new-console-template for more information


List<int> theList = new List<int>();
bool loop = true;
int sum = 0, counter = 0;
int input = Int32.Parse(Console.ReadLine());
int input2 = Int32.Parse(Console.ReadLine());

while (loop)
{
    int input3 = Int32.Parse(Console.ReadLine());
    if(input3 == 0)
    {
        break;
    }
    sum = input + input2 + input3;
    theList.Add(sum);

    input = input2;
    input2 = input3;


}

for(int i = 0; i < theList.Count; i++)
{
    if(i > 0)
    {
        if (theList[i] > theList[i - 1])
        {
            counter++;
        }
    }
}

Console.WriteLine(counter);