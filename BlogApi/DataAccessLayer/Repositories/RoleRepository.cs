using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;
using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleRepository(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        // Creates a new Role record in the database.
        public async Task<Role?> Create(Role role)
        {
            IdentityResult result = await _roleManager.CreateAsync(role);

            if (!result.Succeeded)
            {
                return null;
            }
            return role;
        }

        // Deletes a Role record from the database.
        public async Task<bool> Delete(Role role)
        {
            IdentityResult result = await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                return true;
            }

            return false;
        }

        // Retrieves a list of all Role records from the database.
        public List<Role> Roles()
        {
            return _roleManager.Roles.ToList();
        }

        // Retrieves a specific Role record by its ID.
        public async Task<Role> Role(string id)
        {
            return await _roleManager.FindByIdAsync(id);
        }

        // Updates an existing Role record in the database.
        public async Task<bool> Update(Role role)
        {

            IdentityResult result = await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                return true;
            }

            return false;
        }



    }


        

        
    
}
