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

    private string titolo;
    public string Titolo {
        get => titolo;
        set
        {

            if (value == "") throw new Exception("Titolo non può essere vuoto");
            
            
            titolo = value;
        }
    }

    private DateTime data;
    public DateTime Data {
        get => data;
        set
        {
            DateTime now = DateTime.Now;
            if (value < now ) throw new Exception("Non puoi inserire una data passata");
            data = value;
        }
    }

    private int maxPosti;
    public int MaxPosti {
        get => maxPosti;
        private set
        {
            
            if (maxPosti < 0) throw new ArgumentException("I posti devono essere più di 0");
            maxPosti = value;
        }
    }

    public int PostiOccupati { get; private set; }

    public void PrenotaPosti(int n)
    {
        DateTime now = DateTime.Now;
        if (Data < now) throw new Exception("L'evento è concluso");
        if (PostiOccupati == MaxPosti) throw new Exception("Non ci sono più posti disponibili");
        if (PostiOccupati + n > MaxPosti) throw new Exception("Non ci sono abbastanza posti liberi");

        PostiOccupati += n;
        
    }

    public void DisdiciPosti(int n)
    {
        DateTime now = DateTime.Now;
        if (Data < now) throw new Exception("L'evento è concluso");
        if (PostiOccupati - n < 0) throw new Exception("Non ci sono così tanti posti da disdire");

        PostiOccupati -= n;
    }

    public override string ToString()
    {
        string s = Data.ToString("dd/MM/yyyy") + " - " + Titolo;
        return s;
    }
}
