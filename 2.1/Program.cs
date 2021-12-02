// See https://aka.ms/new-console-template for more information

// Run for integer input
//integers();

// Run for strings inpur
strings();

void integers()
{
    List<int> theList = new List<int>();
    int input = Int32.Parse(Console.ReadLine());

    while (input != 0)
    {
        theList.Add(input);
        input = Int32.Parse(Console.ReadLine());
    }

    
}

void strings()
{
    List<string> theList = new List<string>();
    string input = Console.ReadLine();

    while (input != "0")
    {
        theList.Add(input);
        input = Console.ReadLine();
    }

    string[] separated;
    int horizontal = 0;
    int depth = 0;
    int aim = 0;

    foreach (string str in theList)
    {
        separated = str.Split(' ');
        if(separated[0] == "forward")
        { 
            horizontal += Int32.Parse(separated[1]); 
        }
        else if(separated[0] == "down")
        {
           depth += Int32.Parse(separated[1]);
        }
        else if(separated[0] == "up")
        {
            depth -= Int32.Parse(separated[1]);
        }
        else
        {

        }
        Console.WriteLine("Depth is: " + depth);
    }

    Console.WriteLine($"Depth: {depth}, horizontal: {horizontal}");
}