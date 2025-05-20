namespace sc3_classi.Models;

public class Categoria
{

    public Categoria(string titolo)
    {
        Titolo = titolo;
        NumeroArticoli = 0;
    }

    public string Titolo { get; set; }

    public int NumeroArticoli { get; set; }
}