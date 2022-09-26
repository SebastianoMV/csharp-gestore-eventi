// See https://aka.ms/new-console-template for more information
Console.WriteLine("Eventi");

Console.WriteLine("Inserisci un nuovo evento!");

Console.WriteLine("Nome evento");

string newNome = Console.ReadLine();

Console.WriteLine("Data evento [dd/MM/yyyy");

DateTime newData = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

Console.WriteLine("Inserisci i posti a disposizione");

int newPosti = Int32.Parse(Console.ReadLine());


Evento newEvento = new Evento(newNome, newData, newPosti);

Console.WriteLine(newEvento.ToString());

bool flag = false;

Console.WriteLine("Vuoi prenotare dei posti? [si/no]");

string risposta = Console.ReadLine();

if(risposta == "si")
{
    Console.WriteLine("Quanti posti vuoi prenotare?");
    int posti = Int32.Parse(Console.ReadLine());
    newEvento.PrenotaPosti(posti);
    Console.WriteLine($"Posti prenotati:  {newEvento.PostiOccupati}");
    Console.WriteLine($"Posti liberi: {newEvento.MaxPosti - newEvento.PostiOccupati}");
}

Console.WriteLine("Vuoi disdire dei posti? [si/no]");

risposta = Console.ReadLine();

if (risposta == "si")
{
    Console.WriteLine("Quanti posti vuoi disdire?");
    int posti = Int32.Parse(Console.ReadLine());
    newEvento.DisdiciPosti(posti);
    Console.WriteLine($"Posti prenotati:  {newEvento.PostiOccupati}");
    Console.WriteLine($"Posti liberi: {newEvento.MaxPosti - newEvento.PostiOccupati}");
}