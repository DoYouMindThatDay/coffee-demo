using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace coffee_demo.Services;

public class CoffeeService : ICoffeeService
{
    private readonly List<Coffee> _coffees = new()
    {
        new Coffee(1, "Latte"),
        new Coffee(2, "Cappuccino"),
        new Coffee(3, "Flat White"),
    };

    /// <summary>
    /// Gets all available coffees, unfiltered.
    /// </summary>
    /// <returns>A List of all Coffees.</returns>
    public IEnumerable<Coffee> GetCoffees()
    {
        return _coffees;
    }

    /// <summary>
    /// Finds a coffee by its ID.
    /// </summary>
    /// <param name="id">The ID of the coffee.</param>
    /// <returns>A single coffee.</returns>
    public Coffee? GetCoffee(int id)
    {
        return _coffees.Find(x => x.Id == id);
    }
}
