using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DomainLayer.DTO.UserDto;
using DomainLayer.Models;

namespace BusinessLogicLayer.Servcies
{
    public class UserService : IUserService
    {
        //Private variable that stores the IUserRepository object
        public readonly IUserRepository _userRepository;

        //Constructor of the UserService class
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> CreateUser(User user)
        {
            if(string.IsNullOrWhiteSpace(user.FirstName))
            {
               
                return null;
            }

            if (string.IsNullOrWhiteSpace(user.SecondName))
            {
                
                return null;
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                
                return null;
            }

            if(string.IsNullOrWhiteSpace(user.RoleId))
            {
                
                return null;
            }

            User? createdUser= await  _userRepository.Create(user);
            if (createdUser == null)
            {
                
                return null;
            }
            
            return createdUser;
        }

        public async Task<bool> DeleteUser(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                
                return false;
            }

            User? user = await _userRepository.User(id);

            if (user is null)
            {
                
                return false;
            }

            bool isDeleted = await _userRepository.Delete(user);
            if (isDeleted)
            {
                
                return true;
            }
            
            return false;
        }

        public List<User> GetAllUser()
        {
            return _userRepository.Users();
        }

        public async Task<User?> GetUser(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }
            return await _userRepository.User(id);
        }

        public async Task<User?> UpdateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Id))
            {

                return null;
            }

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {

                return null;
            }

            if (string.IsNullOrWhiteSpace(user.SecondName))
            {

                return null;
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {

                return null;
            }

            if (string.IsNullOrWhiteSpace(user.RoleId))
            {

                return null;
            }

            User? updateUser = await _userRepository.User(user.Id);
            updateUser.FirstName = user.FirstName;
            updateUser.SecondName = user.SecondName;
            updateUser.Email = user.Email;
            updateUser.RoleId = user.RoleId;


            var updatedUser = await _userRepository.Update(updateUser);

            if (updatedUser == null)
            {

                return null;
            }


            return updatedUser;
        }


            //function to login a user
        public async Task<User?> AuthenticateUser(LoginUserDto loginDto)
        {
            if (string.IsNullOrEmpty(loginDto.Email) || string.IsNullOrEmpty(loginDto.Password))
            {
                return null;
            }

            return await _userRepository.Authenticate(loginDto.Email, loginDto.Password);
        }

        
    }
    
}
