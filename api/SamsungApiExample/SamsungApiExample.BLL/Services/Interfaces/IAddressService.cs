using SamsungApiExample.DAL.Models;

namespace SamsungApiExample.BLL.Services.Interfaces;
public interface IAddressService
{
    Task<Address?> GetAddressByUserIdAsync(int userId);
}
