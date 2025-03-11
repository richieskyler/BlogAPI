using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IMapperMethodsInterface;
using DataAccessLayer.Models;
using DomainLayer.DTO.CategoryDto;
using DomainLayer.DTO.CommentDto;

namespace BusinessLogicLayer.MapperMethods
{
    public class CommentMapper : ICommentMapper
    {

        // Maps a CreateCommentRequestDto to a Comment entity for creating a new comment.
        public Comment MapCreateCommentRequesDtoComment(CreateCommentRequestDto createCommentRequestDto)
        {
            return new Comment
            {
                Content = createCommentRequestDto.Content,
                PostId = createCommentRequestDto.PostId,
                UserId = createCommentRequestDto.UserId,
                CreatedAt = DateTime.UtcNow
            };
        }

        // Maps a Comment entity to a CommentDto for returning comment data.
        public CommentDto? MapCommentToCommentDto(Comment comment)
        {
            return new CommentDto
            {
                Id = comment.Id,
                Content = comment.Content,
                PostId = comment.PostId,
                UserId = comment.UserId,
                CreatedAt = comment.CreatedAt,
                UpdatedAt = comment.UpdatedAt
            };
        }

        // Maps an UpdateCommentRequestDto to a Comment entity for updating an existing comment.
        public Comment MapUpdateCommentRequestDtoToComment(UpdateCommentRequestDto updateCommentRequestDto)
        {
            return new Comment
            {
                Id = updateCommentRequestDto.Id,
                Content = updateCommentRequestDto.Content,
                UpdatedAt = DateTime.UtcNow
            };
        }

        // Maps a DeleteCommentRequestDto to a Comment entity for deleting an existing comment.
        public Comment MapDeleteCommentRequestDtoToComment(DeleteCommentRequestDto deleteCommentRequestDto)
        {
            return new Comment
            {
                Id = deleteCommentRequestDto.Id
            };
        }
    }
}
