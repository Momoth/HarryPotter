using HarryPotter.ConsoleApp;

var harry = new Sorcier();

while (harry.EstEnEntrainement)
{
    Console.WriteLine("Incantez une formule !");
    harry.IncanterUnSort(Console.ReadLine() ?? string.Empty);
}