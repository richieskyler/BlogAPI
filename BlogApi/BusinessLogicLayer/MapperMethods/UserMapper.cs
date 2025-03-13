using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IMapperMethodsInterface;
using DataAccessLayer.Models;
using DomainLayer.DTO.UserDto;
using DomainLayer.Models;

namespace BusinessLogicLayer.MapperMethods
{
    public class UserMapper : IUserMapper
    {
        // Maps a CreateUserRequestDto to a User entity for creating a new user.
        public User MapCreateUserRequesDtoUser(CreateUserRequestDto createUserRequestDto)
        {
            return new User
            {
                FirstName = createUserRequestDto.FirstName,
                Email = createUserRequestDto.Email,
                SecondName = createUserRequestDto.SecondName,
                RoleId = createUserRequestDto.RoleId,
                CreatedAt = DateTime.UtcNow
            };
        }

        // Maps a DeleteUserRequestDto to a User entity for deleting an existing user.
        public User MapDeleteUserRequestDtoToUser(DeleteUserRequestDto deleteUserRequestDto)
        {
            return new User
            {
                Id = deleteUserRequestDto.Id
            };
        }

        // Maps an UpdateUserRequestDto to a User entity for updating an existing user.
        public User MapUpdateUserRequestDtoToUser(UpdateUserRequestDto updateUserRequestDto)
        {
            return new User
            {
                Id = updateUserRequestDto.Id,
                FirstName = updateUserRequestDto.FirstName,
                SecondName = updateUserRequestDto.SecondName,
                Email = updateUserRequestDto.Email,
                RoleId = updateUserRequestDto.RoleId,
                UpdateAt = DateTime.UtcNow
            };
        }

        // Maps a User entity to a UserDto for returning user data.
        public UserDto? MapUserToUserDto(User user)
        {
            return new UserDto
            {
                FirstName = user.FirstName,
                Email = user.Email,
                SecondName = user.SecondName,
                RoleId = user.RoleId,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdateAt
            };
        }

        public object MapUserLoginToUserDto<T>(User user)
        {
            return new UserDto
            {
                FirstName = user.FirstName,
                Email = user.Email,
                SecondName = user.SecondName,
                RoleId = user.RoleId,
                
            };
        }
    }
}
