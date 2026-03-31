namespace BlazingPizza.Services;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        // Por ahora, devolvemos un array vacío para que compile
        return Task.FromResult(Array.Empty<Pizza>());
    }
}