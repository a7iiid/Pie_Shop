using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> pisOfTheWeek { get; }
        public HomeViewModel(IEnumerable<Pie> pies) {
        pisOfTheWeek = pies;
        }
    }
}
