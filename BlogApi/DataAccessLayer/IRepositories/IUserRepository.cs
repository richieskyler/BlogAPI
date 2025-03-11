using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.Models;

namespace DataAccessLayer.IRepositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Create User
        /// </summary>
        /// <param name="user"></param>
        /// <returns>User Object</returns>
        Task<User?> Create(User user);

        /// <summary>
        /// List of User
        /// </summary>
        /// <returns>List of User</returns>
        List<User> Users();

        /// <summary>
        /// Update User Details
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Updated Object</returns>
        Task<User?> Update(User user);

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="user"></param>
        Task<bool> Delete(User user);

        /// <summary>
        /// Get product Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User Object by Id</returns>
        Task<User?> User(string id);
    }
}
