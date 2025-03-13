using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace BusinessLogicLayer.IServices
{
    public interface IAuthService
    {
        public interface IAuthService
        {
            /// <summary>
            /// Generates a JWT token for the specified user.
            /// </summary>
            /// <param name="user">The user for whom the JWT token is generated.</param>
            /// <returns>A JWT token as a string.</returns>
            string GenerateJwtToken(User user);

        }
    }
}
