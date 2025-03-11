using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.Models;

namespace DomainLayer.DTO.PostDto
{
    public class PostDto
    {

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Content { get; set; }

        // Foreign key property - stores the ID value of the related Category
        [JsonIgnore]
        public Category? Category { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }


        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("UserId")]
        [JsonIgnore]
        public User? User { get; set; }
        public string UserId { get; set; }


        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("UserTypeId")]
        [JsonIgnore]
        public Role? Role { get; set; }
        public string RoleId { get; set; }
    }
}
