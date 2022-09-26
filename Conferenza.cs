// See https://aka.ms/new-console-template for more information




public class Conferenza : Evento
{
    string Relatore { get; set; }  
    double Prezzo { get; set; }
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



