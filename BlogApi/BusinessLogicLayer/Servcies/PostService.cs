using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.UnitOfWork;

namespace BusinessLogicLayer.Servcies
{
    public class PostService : IPostService
    {
        //Private variable that stores the IPostRepository object
        public readonly IUnitOfWorkRepository _repository;
        //private IPostRepository postRepository;

        //Constructor of the CategoryService class
        public PostService(IUnitOfWorkRepository iUnitOfWorkRepository)
        {
            _repository = iUnitOfWorkRepository;
        }

        //public PostService(IPostRepository postRepository)
        //{
        //    this.postRepository = postRepository;
        //}

        public Post? CreatePost(Post post, out string message)
        {
            // Validate that the content is not empty or whitespace
            if (string.IsNullOrWhiteSpace(post.Content))
            {
                message = "Post content cannot be empty";
                return null;
            }

            // Validate that the UserId is greater than zero
            if (string.IsNullOrWhiteSpace(post.UserId))
            {
                message = "Invalid userId";
                return null;
            }

            // This condition ensures that every post belongs to a category, which is useful for data analytics
            if (post.CategoryId <= 0)
            {
                message = "Invalid categoryId";
                return null;
            }

            // Create the post in the repository
            _repository.postRepository.Create(post);

            // Set success message
            message = "Post created";
            return post;
        }

        public bool DeletePost(int id, out string message)
        {
            // Validate the provided Post ID
            if (id <= 0)
            {
                message = "Invalid Id";
                return false;
            }

            // Retrieve the post by ID from the repository
            Post? post = _repository.postRepository.Get(id);

            // Check if the post exists
            if (post is null)
            {
                message = "Id cannot be found";
                return false;
            }

            // Delete the post using the repository
            _repository.postRepository.Delete(post);

            // Set success message
            message = "Post Deleted Successfully";
            return true;
        }

        public List<Post> GetAllPost()
        {
            // Retrieve all posts from the repository
            return _repository.postRepository.Get();
        }

        public Post? GetPost(int id)
        {
            // Validate the provided Post ID
            if (id <= 0)
            {
                return null;
            }

            // Retrieve the post by ID from the repository
            return _repository.postRepository.Get(id);
        }

        public Post? UpdatePost(Post post, out string message)
        {
            // Validate that Post ID is greater than zero
            if (post.Id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            // Validate that the content is not empty
            if (string.IsNullOrWhiteSpace(post.Content))
            {
                message = "Content is required";
                return null;
            }

            // Validate that the CategoryId is greater than zero
            if (post.CategoryId <= 0)
            {
                message = "Invalid CategoryId";
                return null;
            }

            // Update the post in the repository
            Post? updatedPost = _repository.postRepository.Update(post);

            // Set success message
            message = "Successfully Updated";
            return updatedPost;
        }

    }
}
