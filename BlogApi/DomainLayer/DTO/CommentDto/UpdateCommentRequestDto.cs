using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO.CommentDto
{
    public class UpdateCommentRequestDto
    {
        public int Id { get; set; }
        public string? Content { get; set; }
    }
}
