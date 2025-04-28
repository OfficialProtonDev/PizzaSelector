using PizzaSelector.Models;

namespace PizzaSelector.Interfaces
{
    public interface IPizza
    {
        string Name { get; }
        string Description { get; }
        string ImagePath { get; }
        bool IsGlutenFree { get; }
        bool IsVegetarian { get; }

        IReadOnlyList<string> Ingredients { get; }
        IReadOnlyList<PizzaPrice> Prices { get; }

        string PizzaChef { get; }
    }
}
