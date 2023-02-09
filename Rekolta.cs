//zad. 4 Rekolta
Console.Write("Enter quare meters of the vineyard: ");
var sqm = int.Parse(Console.ReadLine());
Console.Write("Enter kg of grapes per square meters: ");
var grozkg = double.Parse(Console.ReadLine());
Console.Write("Enter needed amounth of wine: ");
var wineneeded = int.Parse(Console.ReadLine());
Console.Write("Enter amount of workers: ");
var workers = int.Parse(Console.ReadLine());

//if
var obshtgroz = sqm * grozkg;
var vino = 0.4 * obshtgroz / 2.5;
var litleft = vino - wineneeded;
var totforworkers = litleft / workers;

//else
var needed = wineneeded - vino;


if (vino > wineneeded)
{
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vino)} liters. {Math.Ceiling(litleft)} liters left -> {Math.Ceiling(totforworkers)} liters per person.");
}
else
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(needed)} liters wine needed");
}