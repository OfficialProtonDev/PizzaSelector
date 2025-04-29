using PizzaSelector.Interfaces;
using PizzaSelector.Models;
using PizzaSelector.Models.Pizzas;

namespace PizzaSelector.Factories
{
    public static class PizzaFactory
    {
        public static IPizza CreatePizza(PizzaType pizzaType)
        {
            return pizzaType switch
            {
                PizzaType.Hawaiian_GF => new HawaiianPizza(),
                PizzaType.ChickenCranberry => new ChickenCranberryPizza(),
                PizzaType.Vegetarian => new VegetarianPizza(),
                _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, null)
            };
        }
    }
}
