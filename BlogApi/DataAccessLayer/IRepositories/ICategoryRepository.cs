using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.IRepositories
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Create Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Category Object</returns>
        Category Create(Category category);

        /// <summary>
        /// List of Category
        /// </summary>
        /// <returns>List of Category</returns>
        List<Category> Get();

        /// <summary>
        /// Update Category Details
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Updated Object</returns>
        Category? Update(Category category);

        /// <summary>
        /// Delete Category
        /// </summary>
        /// <param name="category"></param>
        void Delete(Category category);

        /// <summary>
        /// Get product Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Category Object by Id</returns>
        Category? Get(int id);
    }
}
