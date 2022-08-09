int firstNum = 3;
int secondNum = 5;
Console.WriteLine($"Calculation result: {-6 * Math.Pow(firstNum, 3) + 5 * Math.Pow(firstNum, 2) - 10 * firstNum + 15}");
Console.WriteLine($"Calculation result: {Math.Abs(firstNum) * Math.Sin(firstNum)}");
Console.WriteLine($"Calculation result: {2 * Math.PI * firstNum} ");
Console.WriteLine($"Calculation result: {Math.Max(firstNum, secondNum)}");

Console.WriteLine("\n*****New Year scheduler*****");
var daysAfterNY = DateTime.Now.DayOfYear;
var daysInYear = DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365;
var daysBeforeNY = daysInYear - daysAfterNY;
Console.WriteLine($"{daysAfterNY} days passed from New Year\n{daysBeforeNY} days left to New Year");
Console.WriteLine(new String('*', 28));
Console.ReadKey();
//checked
