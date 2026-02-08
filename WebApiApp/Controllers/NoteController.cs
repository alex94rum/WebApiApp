using BussinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace WebApiApp.Controllers;

[ApiController]
[Route("Note")]
public class NoteController(INoteService noteService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync(string text)
    {
        await noteService.CreateAsync(text);
        return NoContent();
    }
}
