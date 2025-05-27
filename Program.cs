using sc3_classi;

var rb = Manager.CreaAutore("Roberto", "Baggio");
var ft = Manager.CreaAutore("Francesco", "Totti");

var tuts = Manager.CreaCategoria("Tutorials");
var storia = Manager.CreaCategoria("Storia");

Manager.CreaArticolo("Il Cucchiaio", "Testo...", DateTime.Now, tuts, ft);
Manager.CreaArticolo("Vincere da solo", "Testo...", DateTime.Now, storia, rb);

foreach (var categoria in Manager.Categorie)
{
    Console.WriteLine($"Totale articoli {categoria.Titolo}: {categoria.NumeroArticoli}");
}

Console.WriteLine("*** Articoli ***");
foreach (var articolo in Manager.Articoli)
{
    Console.WriteLine(articolo.Titolo);
    Console.WriteLine($"di {articolo.Autore?.NomeCompleto}");
    Console.WriteLine($"pubblicato il {articolo.DataPubblicazione.ToShortDateString()} in {articolo.Categoria?.Titolo}");
    Console.WriteLine();
    Console.WriteLine(articolo.Testo);
    Console.WriteLine();
}

Console.WriteLine($"Totale autori: {Manager.Autori.Count}");
Console.WriteLine($"Totale categorie: {Manager.Categorie.Count}");
Console.WriteLine($"Totale articoli: {Manager.Articoli.Count}");

// commentatore
var lt = Manager.CreaAutore("Leone", "Da Tastiera");
Manager.CreaCommento(rb, lt, "Bravissimo!", DateTime.Now); // leone commenta Baggio
Manager.CreaCommento(Manager.Articoli[0], lt, "Attenzione, non abusare!", DateTime.Now); // Leone commenta Il Cucchiaio
Manager.CreaCommento(Manager.Articoli[0], rb, "Tecnica sopraffina!", DateTime.Now); // Baggio commenta Il Cucchiaio

Console.WriteLine(new String('=', 40));
Console.WriteLine($"Commenti a: {Manager.Articoli[0].Titolo}");
foreach (var c in Manager.Articoli[0].Commenti)
{
    Console.WriteLine($"{c.Testo} - di {c.Autore.NomeCompleto}");
}

