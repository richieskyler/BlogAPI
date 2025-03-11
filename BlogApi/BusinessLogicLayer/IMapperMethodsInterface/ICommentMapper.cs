using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.DTO.CommentDto;

namespace BusinessLogicLayer.IMapperMethodsInterface
{
    public interface ICommentMapper
    {
        /// <summary>
        ///    Converts the CommentrequestDto object to a Comment object
        /// </summary>
        /// <param name="createCommentRequestDto"></param>
        /// <returns>a Comment object</returns>
        Comment MapCreateCommentRequesDtoComment(CreateCommentRequestDto createCommentRequestDto);

        /// <summary>
        /// Converts the Comment object to a CommentDto object
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public CommentDto? MapCommentToCommentDto(Comment comment);

        /// <summary>
        /// Converts the UpdateCommentRequestDto object to Comment Object
        /// </summary>
        /// <param name="updateCommentRequestDto"></param>
        /// <returns></returns>
        public Comment MapUpdateCommentRequestDtoToComment(UpdateCommentRequestDto updateCommentRequestDto);

        /// <summary>
        /// Converts the DeleteCommentRequestDto to Comment object
        /// </summary>
        /// <param name="deleteCommentRequestDto"></param>
        /// <returns></returns>
        public Comment MapDeleteCommentRequestDtoToComment(DeleteCommentRequestDto deleteCommentRequestDto);
    }
}
