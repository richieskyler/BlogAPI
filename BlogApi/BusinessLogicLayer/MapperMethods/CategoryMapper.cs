using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IMapperMethodsInterface;
using DataAccessLayer.Models;
using DomainLayer.DTO.CategoryDto;

namespace BusinessLogicLayer.MapperMethods
{
    public class CategoryMapper : ICategoryMapper
    {
        // Maps a Category entity to a CategoryDto for returning category data.
        public CategoryDto? MapCategoryToCategoryDto(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                CreatedAt = category.CreatedAt,
                UpdatedAt = category.UpdatedAt
            };
        }

        // Maps an UpdateCategoryRequestDto to a Category entity for updating an existing category.
        public Category MapUpdateCategoryRequestDtoToCategory(UpdateCategoryRequestDto updateCategoryRequestDto)
        {
            return new Category
            {
                Id = updateCategoryRequestDto.Id,
                Name = updateCategoryRequestDto.Name,
                Description = updateCategoryRequestDto.Description,
                UpdatedAt = DateTime.UtcNow
            };
        }

        // Maps a DeleteCategoryRequestDto to a Category entity for deleting an existing category.
        public Category MapDeleteCategoryRequestDtoToCategory(DeleteCategoryRequestDto deleteCategoryRequestDto)
        {
            return new Category
            {
                Id = deleteCategoryRequestDto.Id
            };
        }

        // Maps a CreateCategoryRequestDto to a Category entity for creating a new category.
        public Category MapCreateCategoryRequesDtoCategory(CreateCategoryRequestDto createCategoryRequestDto)
        {
            return new Category
            {
                Name = createCategoryRequestDto.Name,
                Description = createCategoryRequestDto.Description,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
