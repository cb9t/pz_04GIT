Console.Write(" Write text your: ");
string textInput = Console.ReadLine().ToLower();
int symbols = 0;
int numChar = 0;
foreach (char caracters in textInput)
    symbols++;
Console.WriteLine($" Your text have {symbols} characters.");