using SamsungApiExample.DAL.Models;

namespace SamsungApiExample.BLL.Services.Interfaces;
public interface IUserService
{
    Task<IEnumerable<User>> GetUsersAsync();
}
