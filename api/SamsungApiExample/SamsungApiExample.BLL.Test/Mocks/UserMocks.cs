using SamsungApiExample.DAL.Models;

namespace SamsungApiExample.BLL.Test.Mock;
internal static class UserMocks
{
    public static List<User> Users => [
        new User { Id = 1, FirstName = "Petru", LastName = "Virlan", Email="petru.virlan@samsung.com"},
        new User { Id = 2, FirstName = "John", LastName = "Doe", Email="john.doe@samsung.com"},
        new User { Id = 3, FirstName = "Doe", LastName = "John", Email="doe.john@samsung.com"} 
    ];
}
