namespace sc3_classi.Models;

public class Articolo
{

    public Articolo(string titolo, string testo, DateTime dataPubblicazione, Categoria categoria, Autore autore)
    {
        Titolo = titolo;
        Testo = testo;
        DataPubblicazione = dataPubblicazione;
        Categoria = categoria;
        Autore = autore;
    }

    public string Titolo { get; set; }

    public string Testo { get; set; }
    public DateTime DataPubblicazione { get; set; }

    public Categoria? Categoria { get; set; }

    public Autore? Autore { get; set; }
}