using BusinessLogicLayer.IMapperMethodsInterface;
using BusinessLogicLayer.IServices;
//using BusinessLogicLayer.UnitOfWorkService;
using DataAccessLayer.Models;
using DomainLayer.DTO.CategoryDto;
using DomainLayer.DTO.CommentDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        public readonly ICommentService _service;
        public readonly ICommentMapper _commentMapper;

        public CommentController(ICommentService iCommentservice, ICommentMapper commentMapper)
        {
            _service = iCommentservice;
            _commentMapper = commentMapper;
        }

        // Retrieves all Commentts and returns them as a list.
        [HttpGet]
        public IActionResult GetComment()
        {
            return Ok(_service.GetAllComment());
        }

        // Retrieves a specific comment by its ID and returns it as a CommentDto.
        [HttpGet]
        public IActionResult GetById(int id)
        {
            Comment? comment = _service.GetComment(id);

            if (comment == null)
            {
                return NotFound();
            }

            CommentDto? commentDto = _commentMapper.MapCommentToCommentDto(comment);
            return Ok(comment);
        }

        // Creates a new comment using the provided CreateCommentRequestDto and returns the created comment as a CommentDto.
        [HttpPost]
        public IActionResult CreateComment(CreateCommentRequestDto createCommentRequestDto)
        {
            Comment mappedComment = _commentMapper.MapCreateCommentRequesDtoComment(createCommentRequestDto);
            Comment? createdComment = _service.CreateComment(mappedComment, out string message);

            if (createdComment == null)
            {
                return BadRequest(message);
            }

            CommentDto? mappedCommentDto = _commentMapper.MapCommentToCommentDto(createdComment);
            return Ok(mappedCommentDto);
        }

        // Updates an existing Comment using the provided UpdateCommentRequestDto and returns the updated comment as a CommentDto.
        [HttpPost]
        public IActionResult UpdateComment([FromBody] UpdateCommentRequestDto updateCommentRequestDto)
        {
            Comment mappedComment = _commentMapper.MapUpdateCommentRequestDtoToComment(updateCommentRequestDto);

            Comment? commentUpdated = _service.UpdateComment(mappedComment, out string message);

            if (commentUpdated is null)
            {
                return BadRequest(message);
            }

            CommentDto? UpdatedCommentDto = _commentMapper.MapCommentToCommentDto(commentUpdated);

            return Ok(UpdatedCommentDto);
        }

        // Deletes a comment using the provided DeleteCommentRequestDto and returns a boolean indicating success or failure.
        [HttpDelete]
        public IActionResult DeleteComment([FromBody] DeleteCommentRequestDto deleteCommentRequestDto)
        {
            Comment mappedComment = _commentMapper.MapDeleteCommentRequestDtoToComment(deleteCommentRequestDto);

            bool commentDeleted = _service.DeleteComment(mappedComment.Id, out string message);

            return Ok(commentDeleted);
        }
    }
}
