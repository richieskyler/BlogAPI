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
    public class CommentService : ICommentService
    {
        public readonly IUnitOfWorkRepository _repository;
        //private ICommentRepository commentRepository;

        //Constructor of the CommentService class
        public CommentService(IUnitOfWorkRepository iUnitOfWorkRepository)
        {
            _repository = iUnitOfWorkRepository;
        }

        //public CommentService(ICommentRepository commentRepository)
        //{
        //    this.commentRepository = commentRepository;
        //}

        public Comment? CreateComment(Comment comment, out string message)
        {
            // Check if the comment content is empty or null
            if (string.IsNullOrWhiteSpace(comment.Content))
            {
                message = "Comment cannot be empty";
                return null;
            }

            // Save the comment to the database using the repository
            _repository.commentRepository.Create(comment);

            // Set success message
            message = "Comment created";
            return comment;
        }

        public bool DeleteComment(int id, out string message)
        {
            // Validate the provided comment ID
            if (id <= 0)
            {
                message = "Invalid";
                return false;
            }

            // Retrieve the comment by ID from the repository
            Comment? comment = _repository.commentRepository.Get(id);

            // Check if the comment exists
            if (comment is null)
            {
                message = "Comment ID doesn't exist";
                return false;
            }

            // Delete the comment using the repository
            _repository.commentRepository.Delete(comment);

            // Set success message
            message = "Comment deleted";
            return true;
        }

        public List<Comment> GetAllComment()
        {
            // Retrieve all comments from the repository
            return _repository.commentRepository.Get();
        }

        public Comment? GetComment(int id)
        {
            // Validate the provided comment ID
            if (id <= 0)
            {
                return null;
            }

            // Retrieve the comment by ID from the repository
            return _repository.commentRepository.Get(id);
        }

        public Comment? UpdateComment(Comment comment, out string message)
        {
            // Validate the comment ID
            if (comment.Id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            // Validate the associated post ID
            if (comment.PostId <= 0)
            {
                message = "Invalid Post Id";
                return null;
            }

            // Validate the user ID associated with the comment
            if (string.IsNullOrWhiteSpace(comment.UserId))
            {
                message = "UserId is Invalid";
                return null;
            }

            // Update the comment in the repository
            Comment? updatedComment = _repository.commentRepository.Update(comment);

            // Set success message
            message = "Successfully Updated";
            return updatedComment;
        }

    }
}


