// See https://aka.ms/new-console-template for more information




public class Conferenza : Evento
{
    string _relatore;
    string Relatore
    {
        get => _relatore;
        set
        {
            if (value == "") throw new Exception("Relatore non può essere vuoto");


            _relatore = value;
        }
    }
    double _prezzo;
    double Prezzo 
    {   get=> _prezzo;
        set 
        {
            if (value < 0) throw new Exception("Prezzo non può essere inferiore a zero");

            _prezzo = value;
        } 
    }
    public Conferenza(string titolo, DateTime data, int maxPosti, string relatore, double prezzo) : base(titolo, data, maxPosti)
    {
        Relatore = relatore;
        Prezzo = prezzo;
    }


    public string GetDataOra()
    {
        string s = Data.ToString("dd/MM/yyyy");
        return s;
    }
    public string GetPrezzo()
    {
        string s = Prezzo.ToString("0.00");
        return s;
    }
    public override string ToString()
    {
        string s = $"{GetDataOra()} - {Titolo} - {Relatore} - {GetPrezzo()}";
        return s;
    }
}



