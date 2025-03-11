using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.Models;

namespace DataAccessLayer.IRepositories
{
    public interface IRoleRepository
    {
        /// <summary>
        /// Create Role
        /// </summary>
        /// <param name="role"></param>
        /// <returns>Role Object</returns>
        Task<Role> Create(Role role);

        /// <summary>
        /// List of Role
        /// </summary>
        /// <returns>List of Role</returns>
        List<Role> Roles();

        /// <summary>
        /// Update Role Details
        /// </summary>
        /// <param name="role"></param>
        /// <returns>Updated Object</returns>
        Task<bool> Update(Role role);

        /// <summary>
        /// Delete Role
        /// </summary>
        /// <param name="role"></param>
        Task<bool> Delete(Role role);

        /// <summary>
        /// Get product Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Role Object by Id</returns>
        Task<Role?> Role(string id);
    }
}
