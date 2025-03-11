using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace DataAccessLayer.Models
{
    public class Post : BaseModel
    {
       
        public string? Content { get; set; }


        // Foreign key property - stores the ID value of the related Category
        public Category? Category { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        

        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }
        public string RoleId { get; set; }


        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("UserId")]
        public User? User { get; set; }
        public string UserId { get; set; }




    }
}
