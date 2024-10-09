using SamsungApiExample.DAL.Models;

namespace SamsungApiExample.DAL.Repositories.Interfaces;
public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
}
