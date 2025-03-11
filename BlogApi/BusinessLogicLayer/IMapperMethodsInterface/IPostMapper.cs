using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.DTO.PostDto;

namespace BusinessLogicLayer.IMapperMethodsInterface
{
    public interface IPostMapper
    {
        /// <summary>
        ///    Converts the PostrequestDto object to a Post object
        /// </summary>
        /// <param name="createPostRequestDto"></param>
        /// <returns>a Post object</returns>
        Post MapCreatePostRequesDtoPost(CreatePostRequestDto createPostRequestDto);

        /// <summary>
        /// Converts the Post object to a PostDto object
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public PostDto? MapPostToPostDto(Post post);

        /// <summary>
        /// Converts the UpdatePostRequestDto object to Post Object
        /// </summary>
        /// <param name="updatePostRequestDto"></param>
        /// <returns></returns>
        public Post MapUpdatePostRequestDtoToPost(UpdatePostRequestDto updatePostRequestDto);

        /// <summary>
        /// Converts the DeletePostRequestDto to Post object
        /// </summary>
        /// <param name="deletePostRequestDto"></param>
        /// <returns></returns>
        public Post MapDeletePostRequestDtoToPost(DeletePostRequestDto deletePostRequestDto);
    }
}
