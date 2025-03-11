using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DomainLayer.Models;

namespace BusinessLogicLayer.Servcies
{
    public class RoleService : IRoleService
    {
        //Private variable that stores the IRoleRepository object
        public readonly IRoleRepository _roleRepository;

        //Constructor of the RoleService class
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

            public async Task<Role?> CreateRole(Role role)
            {
            if (string.IsNullOrWhiteSpace(role.Name))
            {
                return null;
            }

            return await _roleRepository.Create(role);
            
        }

        public async Task<bool> DeleteRole(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            Role? role = await _roleRepository.Role(id);

            if (role is null)
            {
      
                return false;
            }

            return await _roleRepository.Delete(role);
           
        }

        public List<Role> GetAllRole()
        {
            return _roleRepository.Roles();
        }

        public async Task<Role?> GetRole(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }
            return await _roleRepository.Role(id);
        }

        public async Task<bool> UpdateRole(Role role)
        {

            if (string.IsNullOrWhiteSpace(role.Name))
            {
                
                return false;
            }

            if (string.IsNullOrWhiteSpace(role.Id))
            {

                return false;
            }

            Role? updateRole = await _roleRepository.Role(role.Id);

            updateRole.Name = role.Name;


            var updatedRole = await  _roleRepository.Update(updateRole);
            return true;

        }
    }
}
