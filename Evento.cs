// See https://aka.ms/new-console-template for more information
public class Evento
{
    public Evento(string titolo, DateTime data, int maxPosti)
    {
        Titolo = titolo;
        Data = data;
        MaxPosti = maxPosti;
        PostiOccupati = 0;
    }

    public string Titolo {
        get { return Titolo; }
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Titolo non può essere vuoto");
            Titolo = value;
        }
    }
    public DateTime Data {
        get { return Data; }
        set
        {
            DateTime now = DateTime.Now;
            if (Data < now ) throw new ArgumentException("Non puoi inserire una data passata");
            Data = value;
        }
    }

    public int MaxPosti {
        get { return MaxPosti; }
        private set
        {
            
            if (MaxPosti <= 0) throw new ArgumentException("I posti devono essere più di 0");
            MaxPosti = value;
        }
    }

    public int PostiOccupati { get; private set; }

    public void PrenotaPosti(int n)
    {
        DateTime now = DateTime.Now;
        if (Data < now) throw new ArgumentException("L'evento è concluso");
        if (PostiOccupati == MaxPosti) throw new ArgumentException("Non ci sono più posti disponibili");
        if (PostiOccupati + n > MaxPosti) throw new ArgumentException("Non ci sono abbastanza posti liberi");

        PostiOccupati += n;
        
    }
}
