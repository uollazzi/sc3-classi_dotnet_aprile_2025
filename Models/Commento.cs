namespace sc3_classi.Models;

public class Commento
{
    public Commento(Autore autore, DateTime dataPubblicazione, string testo)
    {
        Autore = autore;
        DataPubblicazione = dataPubblicazione;
        Testo = testo;
    }

    public Autore Autore { get; set; }
    public DateTime DataPubblicazione { get; set; }
    public string Testo { get; set; }
}