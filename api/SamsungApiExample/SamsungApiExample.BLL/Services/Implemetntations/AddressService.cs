using SamsungApiExample.BLL.Services.Interfaces;
using SamsungApiExample.DAL.Models;
using SamsungApiExample.DAL.Repositories.Interfaces;

namespace SamsungApiExample.BLL.Services.Implemetntations;
public class AddressService: IAddressService
{
    private readonly IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository ?? throw new ArgumentNullException(nameof(addressRepository));
    }

    public async Task<Address?> GetAddressByUserIdAsync(int userId)
    {
        return await _addressRepository.GetByUserIdAsync(userId);
    }
}
