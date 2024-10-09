using SamsungApiExample.DAL.Models;

namespace SamsungApiExample.BLL.Test.Mock;
internal static class AddressMocks
{
    public static Address Address =>  
        new Address { Id = 1, UserId = 1, City = "Bucharest", Country = "Romania", Street = "Str Martisor", ZipCode = "000000" };
}
