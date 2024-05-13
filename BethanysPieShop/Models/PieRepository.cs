
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly PieDbContext _db;
        public PieRepository(PieDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _db.pies.Include(c=>c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek {
            get
            {
                return _db.pies.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);

            }
        }

        public Pie? GetPieById(int pieId)
        {
          return _db.pies.FirstOrDefault(p=>p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            return _db.pies.Where(p => p.Name == searchQuery);
        }
    }
}
