using Microsoft.AspNetCore.Mvc;
using SamsungApiExample.BLL.Services.Interfaces;
using SamsungApiExample.DAL.Models;

namespace SamsungApiExample.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var result = await _userService.GetUsersAsync();
        return Ok(result);
    }
}
