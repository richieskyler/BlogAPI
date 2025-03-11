
using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.UnitOfWork;

namespace BusinessLogicLayer.Servcies
{
    public class CategoryService : ICategoryService
    {
        

        public readonly IUnitOfWorkRepository _repository;
        //private ICategoryRepository categoryRepository;

        //Constructor of the CategoryService class
        public CategoryService(IUnitOfWorkRepository iUnitOfWorkRepository)
        {
            _repository = iUnitOfWorkRepository;
        }

        //public CategoryService(ICategoryRepository categoryRepository)
        //{
        //    this.categoryRepository = categoryRepository;
        //}

        public Category? CreateCategory(Category category, out string message)
        {
            // Check if the category name is empty or null
            if (string.IsNullOrWhiteSpace(category.Name))
            {
                message = "Name cannot be empty";
                return null;
            }

            // Check if the category description is empty or null
            if (string.IsNullOrWhiteSpace(category.Description))
            {
                message = "Description cannot be empty";
                return null;
            }

            // Save the category to the database using the repository
            _repository.categoryRepository.Create(category);

            // Set success message
            message = "Category created Successfully";
            return category;
        }

        public bool DeleteCategory(int id, out string message)
        {
            // Validate the provided category ID
            if (id <= 0)
            {
                message = "Invalid";
                return false;
            }

            // Retrieve the category by ID from the repository
            Category? category = _repository.categoryRepository.Get(id);

            // Check if the category exists
            if (category == null)
            {
                message = "Return a Number"; // This message seems unclear; consider rewording
                return false;
            }

            // Delete the category using the repository
            _repository.categoryRepository.Delete(category);

            // Set success message
            message = "Deleted Successfully";
            return true;
        }

        public List<Category> GetAllCategory()
        {
            // Retrieve all categories from the repository
            return _repository.categoryRepository.Get();
        }

        public Category? GetCategory(int id)
        {
            // Validate the provided category ID
            if (id <= 0)
            {
                return null;
            }

            // Retrieve the category by ID from the repository
            return _repository.categoryRepository.Get(id);
        }

        public Category? UpdateCategory(Category category, out string message)
        {
            // Validate the category ID
            if (category.Id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            // Validate the category description
            if (string.IsNullOrWhiteSpace(category.Description))
            {
                message = "Description is Required";
                return null;
            }

            // Validate the category name
            if (string.IsNullOrWhiteSpace(category.Name))
            {
                message = "Name is Required";
                return null;
            }

            // Update the category in the repository
            Category? updatedCategory = _repository.categoryRepository.Update(category);

            // Set success message
            message = "Successfully Updated";
            return updatedCategory;
        }

    }
}

