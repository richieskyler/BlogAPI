using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace DataAccessLayer.Models
{
    public class Comment : BaseModel
    {
        public string? Content { get; set; }


        
        [ForeignKey("PostId")]
        public Post? Post { get; set; }
        public int PostId { get; set; }

       
        [ForeignKey("UserId")]
        public User? User { get; set; }
        public string UserId { get; set; }
    }
}
