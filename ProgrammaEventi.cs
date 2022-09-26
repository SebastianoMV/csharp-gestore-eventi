// See https://aka.ms/new-console-template for more information

public class ProgrammaEventi
{
    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        Eventi = new List<Evento>();
    }

    public string Titolo { get; set; }
    public List<Evento> Eventi { get; set; }

    public void NewEvento(Evento evento)
    {
        Eventi.Add(evento);
    }

    public List<Evento> ListaEventiInData(DateTime data)
    {
        List<Evento> lista = new List<Evento>();
        foreach (Evento evento in Eventi)
        {
            if (evento.Data == data)
            {
                lista.Add(evento);
            }
        }

        return lista;
    }

    public static string ListaEventi(List<Evento>  lista){
        string s = "";
        int count = 1;
        foreach (Evento evento in lista)
        {

            s += $"{count}° evento: {evento.ToString()} \n";
            count++;
        }
        return s;
    }

    public int ContaEventi()
    {
        int count = 0;
        foreach(Evento evento in Eventi)
        {
            count++;
        }
        return count;
    }

    public void SvuotaEventi()
    {
        
        Eventi.RemoveRange(0, Eventi.Count());
        Console.WriteLine("Eventi svuotati");
    }

    public string StampaEventi()
    {
        string s = "";
        string stringEventi = "";
        foreach(Evento evento in Eventi)
        {
            stringEventi += $"\r {evento.ToString()} \n";
        }
        s = $"{Titolo} \n " + stringEventi;
        return s;
    }
}
