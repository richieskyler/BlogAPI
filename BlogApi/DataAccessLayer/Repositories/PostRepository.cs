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
    public class PostRepository : IPostRepository
    {


        private ApplicationDbContext _applicationDbContext;

        //Constructor that injects the applicationDbContext object
        public PostRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Method to create post
        public Post Create(Post post)
        {
            _applicationDbContext.Posts.Add(post);
            _applicationDbContext.SaveChanges();
            return post;
        }


        //Method to delete post
        public void Delete(Post post)
        {
            _applicationDbContext.Posts.Remove(post);
        }


        //Method to get all post in the postTable
        public List<Post> Get()
        {
            return _applicationDbContext.Posts.ToList();
        }


        //Method to get a post based on the Id
        public Post? Get(int id)
        {
            Post? post = _applicationDbContext.Posts.Find(id);
            return post;
        }

        //Method for updating post details
        public Post? Update(Post post)
        {
            //Finding the post to update by the id
            Post? existingPost = _applicationDbContext.Posts.Find(post.Id);

            existingPost.Content = post.Content;
            existingPost.CategoryId = post.CategoryId;
            existingPost.UserId = post.UserId;

            //Updating the existing post and Saving the changes
            _applicationDbContext.Posts.Update(existingPost);
            _applicationDbContext.SaveChanges();
            return existingPost;
        }
    }
}
