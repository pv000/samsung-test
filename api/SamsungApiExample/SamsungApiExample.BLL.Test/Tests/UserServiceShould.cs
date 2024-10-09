using Moq;
using SamsungApiExample.BLL.Services.Implemetntations;
using SamsungApiExample.BLL.Test.Mock;
using SamsungApiExample.DAL.Repositories.Interfaces;

namespace SamsungApiExample.BLL.Test.Tests;
internal class UserServiceShould
{
    private Mock<IUserRepository>? _userRepository;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        _userRepository = new Mock<IUserRepository>();
    }

    [TearDown]
    public void TearDown()
    {
        _userRepository!.Reset();
    }

    private UserService GetUserService()
    {
        return new UserService(_userRepository!.Object);
    }

    [Test]
    public async Task GetUsersAsync_ReturnsAllUsers()
    {
        //arange
        var users = UserMocks.Users;
        _userRepository!.Setup(x => x.GetUsersAsync()).ReturnsAsync(users);
        var sut = GetUserService();

        //act
        var result = await sut.GetUsersAsync();

        //assert
        Assert.IsNotNull(result);
        Assert.That(result.Count(), Is.EqualTo(users.Count));
        Assert.That(result.First().FirstName, Is.EqualTo(users[0].FirstName));
    }
}
