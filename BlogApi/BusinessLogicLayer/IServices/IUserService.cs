using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.Models;

namespace BusinessLogicLayer.IServices
{
    public interface IUserService
    {
        /// <summary>
        ///     Get User object
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User object</returns>
        Task<User?> GetUser(string id);


        /// <summary>
        ///     Get all User in the database
        /// </summary>
        /// <returns>List of User Object</returns>
        List<User> GetAllUser();

        /// <summary>
        ///     Remove a User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteUser(string id);


        /// <summary>
        ///     Modify a User object
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Uodated Object</returns>
        Task<User?> UpdateUser(User user);


        /// <summary>
        ///     Create a User
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Create a new User object</returns>
        Task<User?> CreateUser(User user);

    }
}
