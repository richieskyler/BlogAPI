using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.UnitOfWork;

namespace BusinessLogicLayer.Servcies
{
    public class LikeService : ILikeService
    {
        //Private variable that stores the ILikeRepository object 
        public readonly IUnitOfWorkRepository _repository;
        //private ILikeRepository likeRepository;

        //Constructor of the CategoryService class
        public LikeService(IUnitOfWorkRepository iUnitOfWorkRepository)
        {
            _repository = iUnitOfWorkRepository;
        }

        //public LikeService(ILikeRepository likeRepository)
        //{
        //    this.likeRepository = likeRepository;
        //}

        public Like? CreateLike(Like like, out string message)
        {
            // Validate that UserId is greater than zero
            if (string.IsNullOrWhiteSpace(like.UserId))
            {
                message = "UserId cannot be null or zero";
                return null;
            }

            // Validate that PostId is greater than zero
            if (like.PostId <= 0)
            {
                message = "PostId cannot be empty or zero";
                return null;
            }

            // Create the like entry in the repository
            _repository.likeRepository.Create(like);

            // Set success message
            message = "Like created successfully";
            return like;
        }

        public bool DeleteLike(int id, out string message)
        {
            // Validate the provided Like ID
            if (id <= 0)
            {
                message = "Invalid Id";
                return false;
            }

            // Retrieve the Like entry by ID from the repository
            Like? like = _repository.likeRepository.Get(id);

            // Check if the Like entry exists
            if (like is null)
            {
                message = "Id cannot be found";
                return false;
            }

            // Delete the Like entry using the repository
            _repository.likeRepository.Delete(like);

            // Set success message
            message = "Like deleted successfully";
            return true;
        }

        public List<Like> GetAllLike()
        {
            // Retrieve all Likes from the repository
            return _repository.likeRepository.Get();
        }

        public Like? GetLike(int id)
        {
            // Validate the provided Like ID
            if (id <= 0)
            {
                return null;
            }

            // Retrieve the Like entry by ID from the repository
            return _repository.likeRepository.Get(id);
        }

        public Like? UpdateLike(Like like, out string message)
        {
            // Validate that Like ID is greater than zero
            if (like.Id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            // Validate that PostId is greater than zero
            if (like.PostId <= 0)
            {
                message = "Invalid PostId";
                return null;
            }

            // Validate that UserId is greater than zero
            if (string.IsNullOrWhiteSpace(like.UserId))
            {
                message = "Invalid UserId";
                return null;
            }

            // Update the Like entry in the repository
            Like? updatedLike = _repository.likeRepository.Update(like);

            // Set success message
            message = "Successfully updated";
            return updatedLike;
        }

    }
}
