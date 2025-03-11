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
    public class CommentRepository : ICommentRepository
    {

        private ApplicationDbContext _applicationDbContext;

        //Constructor that injects the applicationDbContext object
        public CommentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Method to create comment
        public Comment Create(Comment comment)
        {
            _applicationDbContext.Comments.Add(comment);
            _applicationDbContext.SaveChanges();
            return comment;
        }


        //Method to delete comment
        public void Delete(Comment comment)
        {
            _applicationDbContext.Comments.Remove(comment);
            _applicationDbContext.SaveChanges();
        }


        //Method to get all comment in the CommentTable
        public List<Comment> Get()
        {
            return _applicationDbContext.Comments.ToList();
        }


        //Method to get a comment based on the Id
        public Comment? Get(int id)
        {
            Comment? comment = _applicationDbContext.Comments.Find(id);
            return comment;
        }


        //Method for updating comment details
        public Comment? Update(Comment comment)
        {

            //Finding the comment to update by the id
            Comment? existingComment = _applicationDbContext.Comments.Find(comment.Id);

            //Updating the existing comment and Saving the changes
            existingComment.Content = comment.Content;

            _applicationDbContext.Comments.Update(existingComment);
            _applicationDbContext.SaveChanges();
            return existingComment;
        }
    }
}
