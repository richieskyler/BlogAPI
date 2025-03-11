using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.IRepositories
{
    public interface IPostRepository
    {
        /// <summary>
        /// Create Post
        /// </summary>
        /// <param name="post"></param>
        /// <returns>Post Object</returns>
        Post Create(Post post);

        /// <summary>
        /// List of Post
        /// </summary>
        /// <returns>List of Post</returns>
        List<Post> Get();

        /// <summary>
        /// Update Post Details
        /// </summary>
        /// <param name="post"></param>
        /// <returns>Updated Object</returns>
        Post? Update(Post post);

        /// <summary>
        /// Delete Post
        /// </summary>
        /// <param name="post"></param>
        void Delete(Post post);

        /// <summary>
        /// Get product Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Post Object by Id</returns>
        Post? Get(int id);
    }
}
