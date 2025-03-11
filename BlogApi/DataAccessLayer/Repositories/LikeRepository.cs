using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories
{
    public class LikeRepository : ILikeRepository
    {

        private ApplicationDbContext _applicationDbContext;

        //Constructor that injects the applicationDbContext object
        public LikeRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        //Method to create like
        public Like Create(Like like)
        {
            _applicationDbContext.Likes.Add(like);
            _applicationDbContext.SaveChanges();
            return like;
        }


        //Method to delete like
        public void Delete(Like like)
        {
            _applicationDbContext.Likes.Remove(like);
            _applicationDbContext.SaveChanges();
        }


        //Method to get all like in the likeTable
        public List<Like> Get()
        {
            return _applicationDbContext.Likes.ToList();
        }


        //Method to get a like based on the Id
        public Like? Get(int id)
        {
            Like? like = _applicationDbContext.Likes.Find(id);
            return like;
        }


        //Method for updating like details
        public Like? Update(Like like)
        {
            //Finding the like to update by the id
            Like? existingLike = _applicationDbContext.Likes.Find(like.Id);

            existingLike.PostId = like.PostId;
            existingLike.UserId = like.UserId;

            //Updating the existing like and Saving the changes
            _applicationDbContext.Likes.Update(existingLike);
            _applicationDbContext.SaveChanges();
            return existingLike;


        }
    }
}
