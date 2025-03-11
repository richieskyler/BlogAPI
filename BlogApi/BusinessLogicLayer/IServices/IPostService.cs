using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.IServices
{
    public interface IPostService
    {
        /// <summary>
        ///     Get Post object
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Post object</returns>
        Post? GetPost(int id);


        /// <summary>
        ///     Get all Post in the database
        /// </summary>
        /// <returns>List of Post Object</returns>
        List<Post> GetAllPost();

        /// <summary>
        ///     Remove a Post
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeletePost(int id, out string message);


        /// <summary>
        ///     Modify a Post object
        /// </summary>
        /// <param name="post"></param>
        /// <returns>Uodated Object</returns>
        Post? UpdatePost(Post post, out string message);


        /// <summary>
        ///     Create a Post
        /// </summary>
        /// <param name="post"></param>
        /// <returns>Create a new Post object</returns>
        Post? CreatePost(Post post, out string message);

    }
}
