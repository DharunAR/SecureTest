using SecureTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTest
{
    class TokenCacheService : ITokenCache
    {
        private const string REFRESH_TOKEN = "refresh_token";
        private const string ID_TOKEN = "id_token";
        public Task<string> GetIdTokenAsync()
        {
            return SecureStorage.Default.GetAsync(ID_TOKEN);
        }

        public Task<string> GetRefreshTokenAsync()
        {
            return SecureStorage.Default.GetAsync(REFRESH_TOKEN);
        }

        public bool RemoveRefreshToken()
        {
            throw new NotImplementedException();
        }

        public Task SetIdTokenAsync(string value)
        {
            return SecureStorage.Default.SetAsync(ID_TOKEN, value);
        }

        public Task SetRefreshTokenAsync(string value)
        {
            return SecureStorage.Default.SetAsync(REFRESH_TOKEN, value);
        }
    }
}
