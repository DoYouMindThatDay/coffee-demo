namespace coffee_demo.Interfaces
{
    public interface ICoffeeService
    {
        Coffee? GetCoffee(int id);
        IEnumerable<Coffee> GetCoffees();
    }
}