using Microsoft.AspNetCore.Mvc;
using SamsungApiExample.BLL.Services.Interfaces;

namespace SamsungApiExample.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService)
    {
        _addressService = addressService ?? throw new ArgumentNullException(nameof(addressService));
    }

    [HttpGet]
    public async Task<IActionResult> GetAddressByUserId([FromQuery] int userId)
    {
        var result = await _addressService.GetAddressByUserIdAsync(userId);
        return Ok(result);
    }
}
