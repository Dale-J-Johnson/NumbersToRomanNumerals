Dictionary<string, int> romanNumerals = new()
{
    {"I",   1},
    {"IV",  4},
    {"V",   5},
    {"IX",  9},
    {"X",   10},
    {"XL",  40},
    {"L",   50},
    {"XC",  90},
    {"C",   100},
    {"CD",  400},
    {"D",   500},
    {"CM",  900},
    {"M",   1000}
};

int numberToConvert = 0;
bool validInput = false;
string? result = null;


while (validInput == false)
{
    Console.WriteLine("Enter a number to convert to roman numerals: ");
    string? input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out numberToConvert)) 
    {
        Console.WriteLine("Error, please enter a valid number");
    }
    else
    {
        validInput = true;
    }
}

foreach (var romanNumeral in romanNumerals.Reverse())
{
    while (numberToConvert >= romanNumeral.Value)
    {
        result += romanNumeral.Key;
        numberToConvert -= romanNumeral.Value;
    }
}

Console.WriteLine($"Result is {result}");
Console.ReadLine();