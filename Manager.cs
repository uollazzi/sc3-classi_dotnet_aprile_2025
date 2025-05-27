using sc3_classi.Models;

namespace sc3_classi;

public class Manager
{
    public static List<Autore> Autori { get; } = []; // new List<Autore>()
    public static List<Categoria> Categorie { get; } = [];
    public static List<Articolo> Articoli { get; } = [];

    public static Autore CreaAutore(string nome, string cognome)
    {
        // istanzio l'Autore
        Autore a = new Autore(nome, cognome);

        // inseriamo nell'elenco degli Autori
        Autori.Add(a);

        // ritorno il nuovo autore creato (potrebbe servire a chi chiama questo metodo)
        return a;

    }

    public static Categoria CreaCategoria(string titolo)
    {
        Categoria c = new Categoria(titolo);
        Categorie.Add(c);
        return c;
    }

    public static Articolo CreaArticolo(string titolo, string testo, DateTime dataPubblicazione, Categoria categoria, Autore autore)
    {
        Articolo c = new Articolo(titolo, testo, dataPubblicazione, categoria, autore);
        Articoli.Add(c);
        categoria.NumeroArticoli++;
        return c;
    }

    public static Commento CreaCommento(ICommentabile commentabile, Autore autore, string testo, DateTime dataPubblicazione)
    {
        Commento c = new Commento(autore, dataPubblicazione, testo);
        commentabile.Commenti.Add(c);
        return c;
    }
}