Console.Write(" Write text your: ");
string textInput = Console.ReadLine().ToLower();
int symbols = 0;
int numChar = 0;
foreach (char caracters in textInput)
    symbols++;
Console.WriteLine($" Your text have {symbols} characters.");
Console.Write(" Which symbol do you want to count? - ");
char textChar = char.Parse(Console.ReadLine().ToLower());
foreach (char character in textInput)
{
    if (character == textChar)
        numChar++;
}
Console.WriteLine($" This symbol is used {numChar} times in the text.");