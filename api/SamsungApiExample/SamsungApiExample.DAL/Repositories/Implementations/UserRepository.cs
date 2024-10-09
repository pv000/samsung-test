using Microsoft.EntityFrameworkCore;
using SamsungApiExample.DAL.Context;
using SamsungApiExample.DAL.Models;
using SamsungApiExample.DAL.Repositories.Interfaces;

namespace SamsungApiExample.DAL.Repositories.Implementations;
public class UserRepository : IUserRepository
{
    private readonly DataContext _context;

    public UserRepository(DataContext dataContext)
    {
        _context = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
}
