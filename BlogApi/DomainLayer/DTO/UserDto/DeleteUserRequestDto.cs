using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DomainLayer.DTO.UserDto
{
    public class DeleteUserRequestDto
    {
        public string Id { get; set; }
        
    }
}
