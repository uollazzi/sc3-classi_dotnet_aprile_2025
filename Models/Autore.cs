
namespace sc3_classi.Models;

public class Autore : ICommentabile
{
    public Autore(string nome, string cognome)
    {
        Nome = nome;
        Cognome = cognome;
    }

    public string Nome { get; set; }

    public string Cognome { get; set; }

    public string NomeCompleto { get => $"{Nome} {Cognome}"; }

    public List<Commento> Commenti { get; set; } = [];
}