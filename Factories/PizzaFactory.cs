using PizzaSelector.Interfaces;
using PizzaSelector.Models;

namespace PizzaSelector.Factories
{
    public static class PizzaFactory
    {
        public static IPizza CreatePizza(PizzaType pizzaType)
        {
            return pizzaType switch
            {
                PizzaType.Hawaiian => new Models.Pizzas.HawaiianPizza(),
                PizzaType.ChickenCranberry => new Models.Pizzas.ChickenCranberryPizza(),
                PizzaType.Vegetarian => new Models.Pizzas.VegetarianPizza(),
                _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, null)
            };
        }
    }
}
