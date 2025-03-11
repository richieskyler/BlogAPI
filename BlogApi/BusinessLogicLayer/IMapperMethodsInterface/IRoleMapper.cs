using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
//using DomainLayer.DTO.RoleDto;
using DomainLayer.DTO.UserTypeDto;
using DomainLayer.Models;

namespace BusinessLogicLayer.IMapperMethodsInterface
{
    public interface IRoleMapper
    {
        /// <summary>
        ///    Converts the RolerequestDto object to a Role object
        /// </summary>
        /// <param name="createRoleRequestDto"></param>
        /// <returns>a Role object</returns>
        Role MapCreateRoleRequesDtoRole(CreateRoleRequestDto createRoleRequestDto);

        /// <summary>
        /// Converts the Role object to a RoleDto object
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public RoleDto? MapRoleToRoleDto(Role role);

        /// <summary>
        /// Converts the UpdateRoleRequestDto object to Role Object
        /// </summary>
        /// <param name="updateRoleRequestDto"></param>
        /// <returns></returns>
        public Role MapUpdateRoleRequestDtoToRole(UpdateRoleRequestDto updateRoleRequestDto);

        /// <summary>
        /// Converts the DeleteRoleRequestDto to Role object
        /// </summary>
        /// <param name="deleteRoleRequestDto"></param>
        /// <returns></returns>
        public Role MapDeleteRoleRequestDtoToRole(DeleteRoleRequestDto deleteRoleRequestDto);
    }
}
