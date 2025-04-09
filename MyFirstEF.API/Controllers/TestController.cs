using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstEF.Infrastructure.Data;

namespace MyFirstEF.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DepartmentController : ControllerBase
{
    private readonly MyFirstEFDbContext _context;

    public DepartmentController(MyFirstEFDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllDepartment()
    {
        var departments = await _context.Departments.ToListAsync();
        return Ok(departments);
    }
}