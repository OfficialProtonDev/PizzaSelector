using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaSelector.Interfaces;
using PizzaSelector.Factories;
using PizzaSelector.Models;

namespace PizzaSelector.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public PizzaType SelectedPizzaType { get; set; }

        public IPizza SelectedPizza { get; set; }

        public bool FirstLoad { get; set; } = false;

        public void OnPost()
        {
            SelectedPizza = PizzaFactory.CreatePizza(SelectedPizzaType);
            FirstLoad = SelectedPizza != null;
        }
    }
}
