using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.Models;

namespace DomainLayer.DTO.LikeDto
{
    public class CreateLikeRequestDto
    {
        // Foreign key reference, but hidden from serialization
        [JsonIgnore] // This prevents it from showing in Swagger and responses
        public Post? Post { get; set; }
        [ForeignKey("PostId")]
        public int PostId { get; set; }

        // Foreign key reference, but hidden from serialization
        [JsonIgnore] // This prevents it from showing in Swagger and responses
        public User? User { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }
    }
}
