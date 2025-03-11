using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.Models;

namespace BusinessLogicLayer.IServices
{
    public interface IRoleService
    {
        /// <summary>
        ///     Get Role object
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Role object</returns>
        Task<Role?> GetRole(string id);


        /// <summary>
        ///     Get all Role in the database
        /// </summary>
        /// <returns>List of Role Object</returns>
        List<Role> GetAllRole();

        /// <summary>
        ///     Remove a Role
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteRole(string id);


        /// <summary>
        ///     Modify a Role object
        /// </summary>
        /// <param name="role"></param>
        /// <returns>Uodated Object</returns>
        Task<bool> UpdateRole(Role role);


        /// <summary>
        ///     Create a Role
        /// </summary>
        /// <param name="role"></param>
        /// <returns>Create a new Role object</returns>
        Task<Role?> CreateRole(Role role  );

    }
}
