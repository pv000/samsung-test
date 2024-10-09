using Microsoft.EntityFrameworkCore;
using SamsungApiExample.DAL.Context;
using SamsungApiExample.DAL.Models;
using SamsungApiExample.DAL.Repositories.Interfaces;

namespace SamsungApiExample.DAL.Repositories.Implementations;
public class AddressRepository : IAddressRepository
{
    private readonly DataContext _context;

    public AddressRepository(DataContext dataContext)
    {
        _context = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
    }

    public async Task<Address?> GetByUserIdAsync(int userId)
    {
        return await _context.Addresses.FirstOrDefaultAsync(x => x.UserId == userId);
    }
}
