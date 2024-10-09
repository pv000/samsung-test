using SamsungApiExample.DAL.Models;

namespace SamsungApiExample.DAL.Repositories.Interfaces;
public interface IAddressRepository
{
    Task<Address?> GetByUserIdAsync(int userId);
}
