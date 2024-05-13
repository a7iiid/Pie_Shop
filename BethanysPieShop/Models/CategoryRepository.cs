
namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PieDbContext _db;
        public CategoryRepository( PieDbContext pieDbContext)
        {
            _db=pieDbContext;
        }
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _db.Categories.OrderBy(c=>c.CategoryName);
            }
        }
    }
}
