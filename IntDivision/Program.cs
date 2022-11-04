


// Welcome message
Console.WriteLine("Int Division");
Console.WriteLine("------------");
Console.WriteLine();

// Declare variables
int positiveEvenNumber = 100;
int positiveOddNumber = 99;
int negativeEvenNumber = -100;
int negativeOddNumber = -99;
int divisor = 10;

int positiveEvenResult = positiveEvenNumber / divisor;
int positiveOddResult = positiveOddNumber / divisor;
int negativeEvenResult = negativeEvenNumber/ divisor;
int negativeOddResult = negativeOddNumber/ divisor;

// Show result
Console.WriteLine($"{positiveEvenNumber} / {divisor} = {positiveEvenResult}");
Console.WriteLine($"{positiveOddNumber} / {divisor} = {positiveOddResult}");
Console.WriteLine($"{negativeEvenNumber} / {divisor} = {negativeEvenResult}");
Console.WriteLine($"{negativeOddNumber} / {divisor} = {negativeOddResult}");
Console.ReadLine();