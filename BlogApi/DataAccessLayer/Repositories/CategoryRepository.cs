 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _applicationDbContext;

        //Constructor that injects the applicationDbContext object
        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Method to create category
        public Category Create(Category category)
        {
            _applicationDbContext.Categories.Add(category);
            _applicationDbContext.SaveChanges();
            return category;
        }

        //Method to delete category
        public void Delete(Category category)
        {
            _applicationDbContext.Remove(category);
            _applicationDbContext.SaveChanges();
        }

        //Method to get all category in the CategoryTable
        public List<Category> Get()
        {
            return _applicationDbContext.Categories.ToList();
        }

        //Method to get a category based on the Id
        public Category? Get(int id)
        {
            Category? category = _applicationDbContext.Categories.Find();
            return category;
        }

        //Method for updating category details
        public Category? Update(Category category)
        {

            //Finding the category to update by the id
            Category? existingCategory = _applicationDbContext.Categories.Find(category.Id);

            //Updating the existing category and Saving the changes
            existingCategory.Name = category.Name;
            existingCategory.Description = category.Description;

            
            _applicationDbContext.Categories.Update(existingCategory);
            _applicationDbContext.SaveChanges();
            return category;

        }
    }
}
