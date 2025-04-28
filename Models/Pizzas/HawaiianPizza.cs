namespace PizzaSelector.Models.Pizzas
{
    public class HawaiianPizza : PizzaBase
    {
        public HawaiianPizza()
        {
            _name = "Hawaiian (GF)";
            _description = "A gluten-free Hawaiian pizza with ham & pineapple.";

            _imagePath = "/imgs/hawaiian-pizza.jpg";

            _isGlutenFree = true;
            _isVegetarian = false;

            _ingredients.Add("Tomato Sauce");
            _ingredients.Add("Mozarella Cheese");
            _ingredients.Add("Ham");
            _ingredients.Add("Pineapple");

            _prices.Add(new PizzaPrice { Size = "Small", Price = 8.99f });
            _prices.Add(new PizzaPrice { Size = "Medium", Price = 10.99f });
            _prices.Add(new PizzaPrice { Size = "Large", Price = 12.99f });

            PizzaChefName();
        }
        public override void PizzaChefName()
        {
            _pizzaChef = "Marioni The Third";
        }
    }
}
