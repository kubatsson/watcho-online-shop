using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Security.Cryptography;

using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace e_comm.Helpers
{
    public static class HashHelper
    {
        public static byte[] GetSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        public static string GetHash(string password, byte[] salt)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2
            (
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8)
            );
        }
    }
}
