namespace coffee_demo.apis;

public static class CoffeeApi
{
    public static RouteGroupBuilder MapCoffee(this RouteGroupBuilder group)
    {
        group.MapGet("/", (ICoffeeService coffeeService) =>
            coffeeService.GetCoffees()
        );

        group.MapGet("/{id}", (ICoffeeService coffeeService, int id) =>
            coffeeService.GetCoffee(id)
                is Coffee coffee
                    ? Results.Ok(coffee)
                    : Results.NotFound()
            )
            .Produces<Coffee>()
            .Produces(404);

        return group;
    }
}
