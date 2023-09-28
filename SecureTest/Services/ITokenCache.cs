using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTest.Services
{
    interface ITokenCache
    {
        Task<string> GetIdTokenAsync();
        Task<string> GetRefreshTokenAsync();
        bool RemoveRefreshToken();

        Task SetIdTokenAsync(string value);
        Task SetRefreshTokenAsync(string value);
    }
}
