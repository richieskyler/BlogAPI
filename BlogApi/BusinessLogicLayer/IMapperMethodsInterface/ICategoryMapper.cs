using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.DTO.CategoryDto;

namespace BusinessLogicLayer.IMapperMethodsInterface
{
    public interface ICategoryMapper
    {
        /// <summary>
        ///    Converts the CategoryrequestDto object to a category object
        /// </summary>
        /// <param name="createCategoryRequestDto"></param>
        /// <returns>a category object</returns>
        Category MapCreateCategoryRequesDtoCategory(CreateCategoryRequestDto createCategoryRequestDto);

        /// <summary>
        /// Converts the Category object to a CategoryDto object
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public CategoryDto? MapCategoryToCategoryDto(Category category);

        /// <summary>
        /// Converts the UpdateCategoryRequestDto object to Category Object
        /// </summary>
        /// <param name="updateCategoryRequestDto"></param>
        /// <returns></returns>
        public Category MapUpdateCategoryRequestDtoToCategory(UpdateCategoryRequestDto updateCategoryRequestDto);

        /// <summary>
        /// Converts the DeleteCategoryRequestDto to Category object
        /// </summary>
        /// <param name="deleteCategoryRequestDto"></param>
        /// <returns></returns>
        public Category MapDeleteCategoryRequestDtoToCategory(DeleteCategoryRequestDto deleteCategoryRequestDto);
    }
}
