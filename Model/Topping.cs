using System.Globalization;
namespace BlazingPizza;

public class Topping
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string GetFormattedBasePrice()
    {
        var culturaVE = new CultureInfo("es-VE");
        return Price.ToString("C2", culturaVE);
    }
}
