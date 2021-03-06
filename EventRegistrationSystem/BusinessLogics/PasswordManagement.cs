using System.Security.Cryptography;

namespace EventRegistrationSystem.BusinessLogics
{
    public class PasswordManagement
    {
        public PasswordManagement()
        {

        }

        public byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            using (var algorithm = new SHA256Managed())
            {
                byte[] plainTextWithSaltBytes = new byte[plainText.Length + salt.Length];

                for (int i = 0; i < plainText.Length; i++)
                {
                    plainTextWithSaltBytes[i] = plainText[i];
                }

                for (int i = 0; i < salt.Length; i++)
                {
                    plainTextWithSaltBytes[plainText.Length + i] = salt[i];
                }

                return algorithm.ComputeHash(plainTextWithSaltBytes);
            }
        }

        public bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
