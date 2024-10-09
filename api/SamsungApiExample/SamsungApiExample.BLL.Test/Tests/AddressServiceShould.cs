using Moq;
using SamsungApiExample.BLL.Services.Implemetntations;
using SamsungApiExample.BLL.Test.Mock;
using SamsungApiExample.DAL.Repositories.Interfaces;

namespace SamsungApiExample.BLL.Test.Tests;
internal class AddressServiceShould
{
    private Mock<IAddressRepository>? _addressRepository;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        _addressRepository = new Mock<IAddressRepository>();
    }

    [TearDown]
    public void TearDown()
    {
        _addressRepository!.Reset();
    }

    private AddressService GetAddressService()
    {
        return new AddressService(_addressRepository!.Object);
    }

    [Test]
    public async Task GetAddressByUserIdAsync_ReturnsUserAddress()
    {
        //arange
        var address = AddressMocks.Address;
        _addressRepository!.Setup(x => x.GetByUserIdAsync(It.IsAny<int>())).ReturnsAsync(address);
        var sut = GetAddressService();

        //act
        var result = await sut.GetAddressByUserIdAsync(1);

        //assert
        Assert.IsNotNull(result);
        Assert.That(result.Id, Is.EqualTo(address.Id));
        Assert.That(result.UserId, Is.EqualTo(address.UserId));
        Assert.That(result.Country, Is.EqualTo(address.Country));
        Assert.That(result.City, Is.EqualTo(address.City));
        Assert.That(result.Street, Is.EqualTo(address.Street));
        Assert.That(result.ZipCode, Is.EqualTo(address.ZipCode));
    }
}
