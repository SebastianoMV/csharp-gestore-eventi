// See https://aka.ms/new-console-template for more information
Console.WriteLine("Eventi");

Console.WriteLine("Come si chiama il tuo Programma degli eventi?");
string nomeProgramma = Console.ReadLine();
ProgrammaEventi newProgramma = new ProgrammaEventi(nomeProgramma);
Console.WriteLine("Quanti eventi vuoi inserire?");
int numeroEventi = Int32.Parse(Console.ReadLine());

for (int i = 0; i < numeroEventi; i++)
{
    Evento newEvento = NuovoEvento();
    newProgramma.Eventi.Add(newEvento);
}

Console.WriteLine($"Numero di eventi del programma: {newProgramma.ContaEventi()}");
Console.WriteLine("Ecco il tuo programma eventi:");
Console.WriteLine(newProgramma.StampaEventi());
Console.WriteLine("Cerca eventi per data");
DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

StampaListaData(newProgramma.ListaEventiInData(data));




Evento NuovoEvento()
{
    Evento newEvento = null;

    bool flag = false;
    while (!flag){
        try
        {
            Console.WriteLine("Nome evento");

            string newNome = Console.ReadLine();

            Console.WriteLine("Data evento [dd/MM/yyyy");

            DateTime newData = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Inserisci i posti a disposizione");

            int newPosti = Int32.Parse(Console.ReadLine());

            newEvento = new Evento(newNome, newData, newPosti);
            
            flag = true;
        }
        catch (Exception e)
        {
            
            Console.WriteLine(e.Message);
           
            flag = false;
            continue;
        }
        
    }
    
    return newEvento;
}

void StampaListaData(List<Evento> list)
{
    foreach (Evento evento in list)
    {
        Console.WriteLine(evento.ToString());
    }
}



//PRENOTAZIONE E DISDETTA POSTI 

//Console.WriteLine(newEvento.ToString());

//Console.WriteLine("Vuoi prenotare dei posti? [si/no]");

//string risposta = Console.ReadLine();

//if (risposta == "si")
//{
//    Console.WriteLine("Quanti posti vuoi prenotare?");
//    int posti = Int32.Parse(Console.ReadLine());
//    newEvento.PrenotaPosti(posti);
//    Console.WriteLine($"Posti prenotati:  {newEvento.PostiOccupati}");
//    Console.WriteLine($"Posti liberi: {newEvento.MaxPosti - newEvento.PostiOccupati}");
//}

//Console.WriteLine("Vuoi disdire dei posti? [si/no]");

//risposta = Console.ReadLine();

//if (risposta == "si")
//{
//    Console.WriteLine("Quanti posti vuoi disdire?");
//    int posti = Int32.Parse(Console.ReadLine());
//    newEvento.DisdiciPosti(posti);
//    Console.WriteLine($"Posti prenotati:  {newEvento.PostiOccupati}");
//    Console.WriteLine($"Posti liberi: {newEvento.MaxPosti - newEvento.PostiOccupati}");
//}