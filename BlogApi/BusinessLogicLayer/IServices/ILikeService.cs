using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.IServices
{
    public interface ILikeService
    {
        /// <summary>
        ///     Get Like object
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Like object</returns>
        Like? GetLike(int id);


        /// <summary>
        ///     Get all Like in the database
        /// </summary>
        /// <returns>List of Like Object</returns>
        List<Like> GetAllLike();

        /// <summary>
        ///     Remove a Like
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteLike(int id, out string message);


        /// <summary>
        ///     Modify a Like object
        /// </summary>
        /// <param name="like"></param>
        /// <returns>Uodated Object</returns>
        Like? UpdateLike(Like like, out string message);


        /// <summary>
        ///     Create a Like
        /// </summary>
        /// <param name="like"></param>
        /// <returns>Create a new Like object</returns>
        Like? CreateLike(Like like, out string message);

    }
}
