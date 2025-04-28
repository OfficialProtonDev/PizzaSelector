namespace PizzaSelector.Models.Pizzas
{
    public class ChickenCranberryPizza : PizzaBase
    {
        public ChickenCranberryPizza()
        {
            _name = "Chicken & Cranberry";
            _description = "An exquisite gourmet Chicken & Cranberry pizza.";

            _imagePath = "/imgs/chicken-cranberry-pizza.jpg";

            _isGlutenFree = false;
            _isVegetarian = false;

            _ingredients.Add("Cranberry Sauce");
            _ingredients.Add("Shredded Chicken");
            _ingredients.Add("Mozarella Cheese");
            _ingredients.Add("Red Onion");

            _prices.Add(new PizzaPrice { Size = "Small", Price = 10.99f });
            _prices.Add(new PizzaPrice { Size = "Medium", Price = 13.99f });
            _prices.Add(new PizzaPrice { Size = "Large", Price = 16.99f });

            PizzaChefName();
        }
        public override void PizzaChefName()
        {
            _pizzaChef = "Luigino The Second";
        }
    }
}
