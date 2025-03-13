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
    public class UserRepository : IUserRepository
    {
        //private readonly ApplicationDbContext applicationDbContext;
        private readonly UserManager<User> _userManager;


        //Constructor that injects the applicationDbContext object
        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        // Adds a new user to the database and returns the created user.
        public async Task<User> Create(User user)
        {
            IdentityResult result = await _userManager.CreateAsync(user, user.PasswordHash);

            if (!result.Succeeded)
            {
                return null;
            }
            return user;
        }


        // Removes a user from the database.
        public async Task<bool> Delete(User user)
        {
            IdentityResult result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }


        // Retrieves a list of all users from the database.
        public List<User> Users()
        {
            return _userManager.Users.ToList();
        }


        // Retrieves a specific user by their ID.
        public async Task<User?> User(string id)
        {
            return await _userManager.FindByIdAsync(id);
            
        }


        // Updates an existing user in the database and returns the updated user.
        public async Task<User> Update(User user)
        {

            IdentityResult result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                return null;
            }
            return user;
        }


        public async Task<User?> Authenticate(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return null;
            }

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, password);
            return isPasswordValid ? user : null;
        }

    }
}
