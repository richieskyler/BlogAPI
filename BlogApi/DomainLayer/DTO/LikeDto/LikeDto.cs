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
    public class LikeDto
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [JsonIgnore]
        public Post? Post { get; set; }
        [ForeignKey("PostId")]
        public int PostId { get; set; }

        [JsonIgnore]
        public User? User { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }
    }
}
