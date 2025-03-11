using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IMapperMethodsInterface;
using DataAccessLayer.Models;
using DomainLayer.DTO.LikeDto;

namespace BusinessLogicLayer.MapperMethods
{
    public class LikeMapper : ILikeMapper
    {
        // Maps a CreateLikeRequestDto to a Like entity for creating a new like.
        public Like MapCreateLikeRequesDtoLike(CreateLikeRequestDto createLikeRequestDto)
        {
            return new Like
            {
                PostId = createLikeRequestDto.PostId,
                UserId = createLikeRequestDto.UserId,
                CreatedAt = DateTime.UtcNow
            };
        }

        // Maps a DeleteLikeRequestDto to a Like entity for deleting an existing like.
        public Like MapDeleteLikeRequestDtoToLike(DeleteLikeRequestDto deleteLikeRequestDto)
        {
            return new Like
            {
                Id = deleteLikeRequestDto.Id
            };
        }

        // Maps a Like entity to a LikeDto for returning like data.
        public LikeDto? MapLikeToLikeDto(Like like)
        {
            return new LikeDto
            {
                Id = like.Id,
                CreatedAt = like.CreatedAt,
                UpdatedAt = like.UpdatedAt,
                PostId = like.PostId,
                UserId = like.UserId
            };
        }
    }
}
