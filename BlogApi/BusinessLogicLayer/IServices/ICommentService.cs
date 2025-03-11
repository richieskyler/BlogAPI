using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.IServices
{
    public interface ICommentService
    {
        /// <summary>
        ///     Get Comment object
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Comment object</returns>
        Comment? GetComment(int id);


        /// <summary>
        ///     Get all Comment in the database
        /// </summary>
        /// <returns>List of Comment Object</returns>
        List<Comment> GetAllComment();

        /// <summary>
        ///     Remove a Comment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteComment(int id, out string message);


        /// <summary>
        ///     Modify a Comment object
        /// </summary>
        /// <param name="comment"></param>
        /// <returns>Uodated Object</returns>
        Comment? UpdateComment(Comment comment, out string message);


        /// <summary>
        ///     Create a Comment
        /// </summary>
        /// <param name="comment"></param>
        /// <returns>Create a new Comment object</returns>
        Comment? CreateComment(Comment comment, out string message);

    }
}
