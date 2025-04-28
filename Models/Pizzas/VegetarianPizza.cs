namespace PizzaSelector.Models.Pizzas
{
    public class VegetarianPizza : PizzaBase
    {
        public VegetarianPizza()
        {
            _name = "Vegetarian";
            _description = "A loaded Vegetarian pizza.";

            _imagePath = "/imgs/vegetarian-pizza.jpg";

            _isGlutenFree = false;
            _isVegetarian = true;

            _ingredients.Add("Tomato Sauce");
            _ingredients.Add("Mozarella Cheese");
            _ingredients.Add("Artichokes");
            _ingredients.Add("Cherry Tomatoes");
            _ingredients.Add("Bell Peppers");
            _ingredients.Add("Olives");
            _ingredients.Add("Red Onion");
            _ingredients.Add("Baby Spinach");

            _prices.Add(new PizzaPrice { Size = "Small", Price = 11.99f });
            _prices.Add(new PizzaPrice { Size = "Medium", Price = 14.99f });
            _prices.Add(new PizzaPrice { Size = "Large", Price = 17.99f });

            PizzaChefName();
        }
        public override void PizzaChefName()
        {
            _pizzaChef = "Peachino The Traitorous Vegetarian";
        }
    }
}
