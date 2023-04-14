using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext appDbContext) 
        { 
            _context = appDbContext;
        }

        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return _context.Categories;
            }
        }
    }
}
