using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IMapperMethodsInterface;
using DataAccessLayer.Models;
using DomainLayer.DTO.PostDto;

namespace BusinessLogicLayer.MapperMethods
{
    public class PostMapper : IPostMapper
    {
        // Maps a CreatePostRequestDto to a Post entity for creating a new post.
        public Post MapCreatePostRequesDtoPost(CreatePostRequestDto createPostRequestDto)
        {
            return new Post
            {
                Content = createPostRequestDto.Content,
                CategoryId = createPostRequestDto.CategoryId,
                RoleId = createPostRequestDto.RoleId,
                CreatedAt = DateTime.UtcNow,
                UserId = createPostRequestDto.UserId
            };
        }

        // Maps a DeletePostRequestDto to a Post entity for deleting an existing post.
        public Post MapDeletePostRequestDtoToPost(DeletePostRequestDto deletePostRequestDto)
        {
            return new Post
            {
                Id = deletePostRequestDto.Id
            };
        }

        // Maps a Post entity to a PostDto for returning post data.
        public PostDto? MapPostToPostDto(Post post)
        {
            return new PostDto
            {
                Id = post.Id,
                Content = post.Content,
                CategoryId = post.CategoryId,
                RoleId = post.RoleId,
                CreatedAt = post.CreatedAt,
                UpdatedAt = post.UpdatedAt
            };
        }

        // Maps an UpdatePostRequestDto to a Post entity for updating an existing post.
        public Post MapUpdatePostRequestDtoToPost(UpdatePostRequestDto updatePostRequestDto)
        {
            return new Post
            {
                Id = updatePostRequestDto.Id,
                Content = updatePostRequestDto.Content,
                CategoryId = updatePostRequestDto.CategoryId,
                UserId = updatePostRequestDto.UserId,
                UpdatedAt = DateTime.UtcNow
            };
        }
    }
}

