using PizzaSelector.Interfaces;

namespace PizzaSelector.Models
{
    public abstract class PizzaBase : IPizza
    {
        protected string _name;
        protected string _description;
        protected string _imagePath;
        protected bool _isGlutenFree;
        protected bool _isVegetarian;
        protected List<string> _ingredients = new List<string>();
        protected List<PizzaPrice> _prices = new List<PizzaPrice>();
        protected string _pizzaChef;

        public string Name => _name;
        public string Description => _description;
        public string ImagePath => _imagePath;
        public bool IsGlutenFree => _isGlutenFree;
        public bool IsVegetarian => _isVegetarian;
        public IReadOnlyList<string> Ingredients => _ingredients;
        public IReadOnlyList<PizzaPrice> Prices => _prices;
        public string PizzaChef => _pizzaChef;

        public abstract void PizzaChefName();
    }
}
