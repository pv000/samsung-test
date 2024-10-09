using SamsungApiExample.BLL.Services.Interfaces;
using SamsungApiExample.DAL.Models;
using SamsungApiExample.DAL.Repositories.Interfaces;

namespace SamsungApiExample.BLL.Services.Implemetntations;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    }

    public Task<IEnumerable<User>> GetUsersAsync()
    {
        return _userRepository.GetUsersAsync();
    }
}
