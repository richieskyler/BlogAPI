using BusinessLogicLayer.IMapperMethodsInterface;
using BusinessLogicLayer.IServices;
using DataAccessLayer.Models;
//using DomainLayer.DTO.RoleDto;
using DomainLayer.DTO.UserTypeDto;
using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IRoleMapper _roleMapper;

        public RoleController(IRoleService roleService, IRoleMapper roleMapper)
        {
            _roleService = roleService;
            _roleMapper = roleMapper;
        }

        // Retrieves all Roles and returns them as a list.
        [HttpGet]
        public IActionResult GetAllRoles()
        {
            var roles = _roleService.GetAllRole();
            var roleDtos = roles.Select(role => _roleMapper.MapRoleToRoleDto(role)).ToList();
            return Ok(roleDtos);
        }

        // Retrieves a specific role by its ID and returns it as a RoleDto.
        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            Role? role = await _roleService.GetRole(id);
            if (role == null)
            {
                return NotFound();
            }
            RoleDto? roleDto = _roleMapper.MapRoleToRoleDto(role);
            return Ok(roleDto);
        }

        // Creates a new role using the provided CreateRoleRequestDto and returns the created role as a RoleDto.
        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleRequestDto createRoleRequestDto)
        {
            Role mappedRole = _roleMapper.MapCreateRoleRequesDtoRole(createRoleRequestDto);
            Role? createdRole = await _roleService.CreateRole(mappedRole);
            if (createdRole == null)
            {
                return BadRequest("Failed to create role. Please check the provided data.");
            }
            RoleDto? mappedRoleDto = _roleMapper.MapRoleToRoleDto(createdRole);
            return CreatedAtAction(nameof(GetById), new { id = createdRole.Id }, mappedRoleDto);
        }

        // Updates an existing Role using the provided UpdateRoleRequestDto and returns success or failure.
        [HttpPut]
        public async Task<IActionResult> UpdateRole(string id, [FromBody] UpdateRoleRequestDto updateRoleRequestDto)
        {
            if (id != updateRoleRequestDto.Id)
            {
                return BadRequest("ID in URL does not match ID in request body");
            }

            Role mappedRole = _roleMapper.MapUpdateRoleRequestDtoToRole(updateRoleRequestDto);
            bool isUpdated = await _roleService.UpdateRole(mappedRole);
            if (!isUpdated)
            {
                return BadRequest("Failed to update role. Please check the provided data.");
            }

            Role? updatedRole = await _roleService.GetRole(id);
            if (updatedRole == null)
            {
                return StatusCode(500, "Role was updated but could not be retrieved");
            }

            RoleDto? updatedRoleDto = _roleMapper.MapRoleToRoleDto(updatedRole);
            return Ok(updatedRoleDto);
        }

        // Deletes a role by ID and returns a boolean indicating success or failure.
        [HttpDelete]
        public async Task<IActionResult> DeleteRole(string id)
        {
            bool roleDeleted = await _roleService.DeleteRole(id);
            if (!roleDeleted)
            {
                return NotFound("Role not found or could not be deleted");
            }
            return Ok(roleDeleted);
        }
    }
}
