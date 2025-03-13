using BusinessLogicLayer.IMapperMethodsInterface;
using BusinessLogicLayer.IServices;
using BusinessLogicLayer.Servcies;

//using BusinessLogicLayer.UnitOfWorkService;
using DataAccessLayer.Models;
using DomainLayer.DTO.UserDto;
using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
            public readonly IUserService _service;
            public readonly IUserMapper _userMapper;
            public readonly AuthService _authService;

        public UserController(IUserService iUserService, IUserMapper userMapper, AuthService authService )
            {
                _service = iUserService;
                _userMapper = userMapper;
                _authService = authService;
            }

            // Retrieves all Userts and returns them as a list.
            [HttpGet]
            public IActionResult GetAllUser()
            {
                return Ok(_service.GetAllUser());
            }

        // Retrieves a specific user by its ID and returns it as a UserDto.
        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            User? user = await _service.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            UserDto? userDto = _userMapper.MapUserToUserDto(user);
            return Ok(userDto);
        }

        // Creates a new user using the provided CreateUserRequestDto and returns the created user as a UserDto.
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestDto createUserRequestDto)
        {
            User mappedUser = _userMapper.MapCreateUserRequesDtoUser(createUserRequestDto);
            User? createdUser = await _service.CreateUser(mappedUser);
            if (createdUser == null)
            {
                return BadRequest("Failed to create user. Please check the provided data.");
            }
            UserDto? mappedUserDto = _userMapper.MapUserToUserDto(createdUser);
            return CreatedAtAction(nameof(GetById), new { id = createdUser.Id }, mappedUserDto);
        }

        // Updates an existing User using the provided UpdateUserRequestDto and returns the updated user as a UserDto.
        [HttpPut]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] UpdateUserRequestDto updateUserRequestDto)
        {
            if (id != updateUserRequestDto.Id)
            {
                return BadRequest("ID in URL does not match ID in request body");
            }

            User mappedUser = _userMapper.MapUpdateUserRequestDtoToUser(updateUserRequestDto);
            User? userUpdated = await _service.UpdateUser(mappedUser);
            if (userUpdated is null)
            {
                return BadRequest("Failed to update user. Please check the provided data.");
            }
            UserDto? updatedUserDto = _userMapper.MapUserToUserDto(userUpdated);
            return Ok(updatedUserDto);
        }

        // Deletes a user by ID and returns a boolean indicating success or failure.
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string id)
        {
            bool userDeleted = await _service.DeleteUser(id);
            if (!userDeleted)
            {
                return NotFound("User not found or could not be deleted");
            }
            return Ok(userDeleted);
        }

        // Endpoint for user login
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginDto)
        {
            var user = await _service.AuthenticateUser(loginDto);
            if (user == null)
            {
                return Unauthorized(new { Message = "Invalid email or password" });
            }

            // Generate JWT token using the AuthService
            var token = _authService.GenerateJwtToken(user);

            return Ok(new
            {
                Token = token,
                User = _userMapper.MapUserLoginToUserDto<UserDto>(user)
            });
        }



    }
}
