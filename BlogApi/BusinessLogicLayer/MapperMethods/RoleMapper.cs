using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IMapperMethodsInterface;
using DataAccessLayer.Models;
//using DomainLayer.DTO.RoleDto;
using DomainLayer.DTO.UserTypeDto;
using DomainLayer.Models;

namespace BusinessLogicLayer.MapperMethods
{
    public class RoleMapper : IRoleMapper
    {
        // Maps a CreateRoleRequestDto to a Role entity for creating a new user type.
        public Role MapCreateRoleRequesDtoRole(CreateRoleRequestDto createRoleRequestDto)
        {
            return new Role
            {
                Name = createRoleRequestDto.Name,
                CreatedAt = DateTime.UtcNow
            };
        }

        // Maps a DeleteRoleRequestDto to a Role entity for deleting an existing user type.
        public Role MapDeleteRoleRequestDtoToRole(DeleteRoleRequestDto deleteRoleRequestDto)
        {
            return new Role
            {
                Id = deleteRoleRequestDto.Id
            };
        }

        // Maps an UpdateRoleRequestDto to a Role entity for updating an existing user type.
        public Role MapUpdateRoleRequestDtoToRole(UpdateRoleRequestDto updateRoleRequestDto)
        {
            return new Role
            {
                Id = updateRoleRequestDto.Id,
                Name = updateRoleRequestDto.Name,
                UpdatedAt = DateTime.UtcNow
            };
        }

        // Maps a Role entity to a RoleDto for returning user type data.
        public RoleDto? MapRoleToRoleDto(Role role)
        {
            return new RoleDto
            {
                Id = role.Id,
                Name = role.Name,
                UpdatedAt = role.UpdatedAt,
                CreatedAt = role.CreatedAt
            };
        }
    }
}
