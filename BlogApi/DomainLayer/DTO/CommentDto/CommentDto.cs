using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.Models;

namespace DomainLayer.DTO.CommentDto
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("PostId")]
        [JsonIgnore]
        public Post? Post { get; set; }
        public int PostId { get; set; }


        [ForeignKey("UserId")]
        [JsonIgnore]
        public User? User { get; set; }
        public string UserId { get; set; }
    }
}
