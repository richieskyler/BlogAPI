using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.DTO.UserDto;
using DomainLayer.Models;

namespace BusinessLogicLayer.IMapperMethodsInterface
{
    public interface IUserMapper
    {
        /// <summary>
        ///    Converts the UserrequestDto object to a User object
        /// </summary>
        /// <param name="createUserRequestDto"></param>
        /// <returns>a User object</returns>
        User MapCreateUserRequesDtoUser(CreateUserRequestDto createUserRequestDto);

        /// <summary>
        /// Converts the User object to a UserDto object
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public UserDto? MapUserToUserDto(User user);

        /// <summary>
        /// Converts the UpdateUserRequestDto object to User Object
        /// </summary>
        /// <param name="updateUserRequestDto"></param>
        /// <returns></returns>
        public User MapUpdateUserRequestDtoToUser(UpdateUserRequestDto updateUserRequestDto);

        /// <summary>
        /// Converts the DeleteUserRequestDto to User object
        /// </summary>
        /// <param name="deleteUserRequestDto"></param>
        /// <returns></returns>
        public User MapDeleteUserRequestDtoToUser(DeleteUserRequestDto deleteUserRequestDto);
        object MapUserLoginToUserDto<T>(User user);
    }
}
