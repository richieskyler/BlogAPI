
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DomainLayer.Models
{
    public class User :IdentityUser<string>
    {
        public string  FirstName { get; set; }

        public String SecondName { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdateAt { get; set; }

        [ForeignKey("RoleId")]
        public Role? Role { get; set; }
        public string RoleId { get; set; }
    }
}
