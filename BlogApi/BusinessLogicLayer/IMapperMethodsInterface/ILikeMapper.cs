using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.DTO.LikeDto;

namespace BusinessLogicLayer.IMapperMethodsInterface
{
    public interface ILikeMapper
    {
        /// <summary>
        ///    Converts the LikerequestDto object to a Like object
        /// </summary>
        /// <param name="createLikeRequestDto"></param>
        /// <returns>a Like object</returns>
        Like MapCreateLikeRequesDtoLike(CreateLikeRequestDto createLikeRequestDto);

        /// <summary>
        /// Converts the Like object to a LikeDto object
        /// </summary>
        /// <param name="like"></param>
        /// <returns></returns>
        public LikeDto? MapLikeToLikeDto(Like like);


        /// <summary>
        /// Converts the DeleteLikeRequestDto to Like object
        /// </summary>
        /// <param name="deleteLikeRequestDto"></param>
        /// <returns></returns>
        public Like MapDeleteLikeRequestDtoToLike(DeleteLikeRequestDto deleteLikeRequestDto);
    }
}
