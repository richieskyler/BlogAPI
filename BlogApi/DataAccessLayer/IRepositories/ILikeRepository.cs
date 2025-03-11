using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.IRepositories
{
    public interface ILikeRepository
    {
        /// <summary>
        /// Create Like
        /// </summary>
        /// <param name="like"></param>
        /// <returns>Like Object</returns>
        Like Create(Like like);

        /// <summary>
        /// List of Like
        /// </summary>
        /// <returns>List of Like</returns>
        List<Like> Get();

        /// <summary>
        /// Update Like Details
        /// </summary>
        /// <param name="like"></param>
        /// <returns>Updated Object</returns>
        Like? Update(Like like);

        /// <summary>
        /// Delete Like
        /// </summary>
        /// <param name="Like"></param>
        void Delete(Like like);

        /// <summary>
        /// Get product Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Like Object by Id</returns>
        Like? Get(int id);
    }
}
