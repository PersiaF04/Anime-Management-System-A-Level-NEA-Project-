using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AMS
{
    /// <summary>
    /// Handles all inputs and validation of functions that will take place in <c>Class: Encryption</c>
    /// </summary>
    public class Encryption
    {    /// <summary>
         /// The resulting method for where Encryption takes place
         /// </summary>
         /// <param name="password"> The <see cref="System.Object"/> that represents the user's password  </param>
        public static string HashPassword(string password)
        {
            //Declaring the hash function variable
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            //Gets the bytes of the ASCII value of the password
            byte[] Passwordbytes = Encoding.ASCII.GetBytes(password);

            //hashes the bytes of the password
            byte[] Encryptedbytes = sha1.ComputeHash(Passwordbytes);

            //returns the password as a string
            return Convert.ToBase64String(Encryptedbytes);
        }
    }
}
