using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.IRepositories
{
    public interface ICommentRepository
    {
        /// <summary>
        /// Create Comment
        /// </summary>
        /// <param name="comment"></param>
        /// <returns>Comment Object</returns>
        Comment Create(Comment comment);

        /// <summary>
        /// List of Comment
        /// </summary>
        /// <returns>List of Comment</returns>
        List<Comment> Get();

        /// <summary>
        /// Update Comment Details
        /// </summary>
        /// <param name="comment"></param>
        /// <returns>Updated Object</returns>
        Comment? Update(Comment comment);

        /// <summary>
        /// Delete Comment
        /// </summary>
        /// <param name="comment"></param>
        void Delete(Comment comment);

        /// <summary>
        /// Get product Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Comment Object by Id</returns>
        Comment? Get(int id);
    }
}
