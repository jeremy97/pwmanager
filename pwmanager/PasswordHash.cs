using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace pwmanager {
    public class PasswordHash {

        public static string HashPassword(string password) {
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, 32);
            rfc.IterationCount = 1000;
            byte[] hash = rfc.GetBytes(20);
            byte[] salt = rfc.Salt;

            return Convert.ToBase64String(salt) + "|" + Convert.ToBase64String(hash);
        }

        public static string HashPassword(string password, byte[] salt) {
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, salt);
            rfc.IterationCount = 1000;
            byte[] hash = rfc.GetBytes(20);

            return Convert.ToBase64String(salt) + "|" + Convert.ToBase64String(hash);
        }

        public static bool ValidatePassword(string password, string saltHash) {
            //split[0] = salt, split[1] = hash
            string[] split = saltHash.Split('|');

            byte[] salt = Convert.FromBase64String(split[0]);

            return HashPassword(password, salt) == saltHash;
        }
    }
}
