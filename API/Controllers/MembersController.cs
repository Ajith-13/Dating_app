using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController(AppDbContext context) : ControllerBase
{
    [HttpGet]  //http://localhost:5001/api/members
    public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembers()
    {
        var members = await context.Users.ToListAsync();
        return Ok(members);
    }

    [HttpGet("{id}")]    //http://localhost:5001/api/members/1
    public async Task<ActionResult<AppUser>> GetMember(string id)
    {
        var member = await context.Users.FindAsync(id);
        if (member == null) return NotFound();
        return Ok(member);
    }
}
