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