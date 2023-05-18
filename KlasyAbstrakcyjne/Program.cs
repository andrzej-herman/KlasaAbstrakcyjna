using KlasyAbstrakcyjne;

CW();
var listaFigur = new List<Figura>();

var fig1 = new Kwadrat(new List<double> { 4.0 });
var fig2 = new Okrag(new List<double> { 6.0 });
var fig3 = new Prostokat(new List<double> { 8.0, 14.0 });
var fig4 = new Trojkat(new List<double> { 11.0, 3.5 });

listaFigur.Add(fig1);
listaFigur.Add(fig2);
listaFigur.Add(fig3);
listaFigur.Add(fig4);

var index = 1;
foreach (var figura in listaFigur)
{
    figura.ObliczPole();
    CW($"Figura {index}: {figura.Pole}");
    index++;
}

Console.ReadLine();







void CW(string? text = null)
{
    if (text == null)
    {
        Console.WriteLine();
        return;
    }

    Console.WriteLine($" {text}");
}
