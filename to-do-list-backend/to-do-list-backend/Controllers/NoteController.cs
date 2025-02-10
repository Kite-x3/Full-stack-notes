using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using to_do_list_backend.DTOs;

namespace to_do_list_backend.Controllers
{
    [ApiController]
    [Route("Note")]
    public class NoteController(INoteService noteService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateNoteDto note)
        {
            await noteService.CreateAsync(note.text, note.title);
            return NoContent();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetNoteAsync([FromRoute]int id)
        {
            var result = await noteService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateNoteAsync([FromRoute] int id, [FromBody] UpdateNoteDto note)
        {
            await noteService.UpdateAsync(id, note.text, note.title);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteNoteAsync([FromRoute] int id)
        {
            await noteService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNotes()
        {
            
            return Ok(await noteService.GetAllAsync());
        }
    }
}
