using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.Models;

namespace DomainLayer.DTO.UserDto
{
    public class CreateUserRequestDto
    {
        public string? FirstName { get; set; }

        public string? SecondName { get; set; }
        public string? Email { get; set; }

        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("RoleId")]
        // Navigation property - gives you access to the full Category object

        // Foreign key reference, but hidden from serialization
        [JsonIgnore] // This prevents it from showing in Swagger and responses
        public Role? Role { get; set; }
        public string RoleId { get; set; }
    }
}
