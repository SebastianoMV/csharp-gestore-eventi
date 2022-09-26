// See https://aka.ms/new-console-template for more information
Console.WriteLine("Eventi");
//Conferenza newConferenza = new Conferenza("Conferenza di Star Wars", DateTime.ParseExact("25/11/2022", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture), 1000, "SebastianoMV", 30.00);

Console.WriteLine("Come si chiama il tuo Programma degli eventi?");
string nomeProgramma = Console.ReadLine();
ProgrammaEventi newProgramma = new ProgrammaEventi(nomeProgramma);
Console.WriteLine("Quanti eventi vuoi inserire?");
int numeroEventi = Int32.Parse(Console.ReadLine());

for (int i = 0; i < numeroEventi; i++)
{
    Console.WriteLine("Vuoi inserire un evento o una conferenza? [0/1] \n 0. Evento \n 1. Conferenza");
    if(Console.ReadLine() == "0")
    {
        Evento newEvento = NuovoEvento();
        newProgramma.Eventi.Add(newEvento);
    }
    else
    {
        Conferenza newConferenza = NuovaConferenza();
        newProgramma.Eventi.Add(newConferenza);
    }
    
}

Console.WriteLine($"Numero di eventi del programma: {newProgramma.ContaEventi()}");
Console.WriteLine("Ecco il tuo programma eventi:");
Console.WriteLine(newProgramma.StampaEventi());
Console.WriteLine("Cerca eventi per data");
DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

StampaListaData(newProgramma.ListaEventiInData(data));
newProgramma.Eventi.Count();

//newProgramma.SvuotaEventi();



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

Conferenza NuovaConferenza(){
    Conferenza newConferenza = null;

    bool flag = false;
    while (!flag)
    {
        try
        {
            Console.WriteLine("Nome conferenza");

            string newNome = Console.ReadLine();

            Console.WriteLine("Data evento [dd/MM/yyyy");

            DateTime newData = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Inserisci i posti a disposizione");

            int newPosti = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il relatore");

            string newRelatore = Console.ReadLine();

            Console.WriteLine("Inserisci il prezzo");

            double newPrezzo = 0;
            bool flagPrezzo = false;
            while (!flagPrezzo)
            {
                try
                {
                    newPrezzo = Double.Parse(Console.ReadLine());
                    flagPrezzo = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("OOOOOOOOOOOOOOOOH");
                }
                
            }
             

            newConferenza = new Conferenza(newNome, newData, newPosti, newRelatore, newPrezzo);

            flag = true;
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);

            flag = false;
            continue;
        }

    }

    return newConferenza;
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