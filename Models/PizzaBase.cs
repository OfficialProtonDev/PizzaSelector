namespace PizzaSelector.Models
{
    public abstract class PizzaBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVegetarian { get; set; }

        public List<string> Ingredients { get; set; }
        public List<PizzaPrice> Prices { get; set; }

        public string PizzaChef { get; set; }

    }
}
