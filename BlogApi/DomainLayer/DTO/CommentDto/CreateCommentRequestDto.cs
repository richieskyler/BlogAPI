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
    public class CreateCommentRequestDto
    {
        public string? Content { get; set; }

        [ForeignKey("PostId")]
        // Foreign key reference, but hidden from serialization
        [JsonIgnore] // This prevents it from showing in Swagger and responses
        public Post? Post { get; set; }
        public int PostId { get; set; }


        [ForeignKey("UserId")]
        // Foreign key reference, but hidden from serialization
        [JsonIgnore] // This prevents it from showing in Swagger and responses
        public User? User { get; set; }
        public string UserId { get; set; }
    }
}
