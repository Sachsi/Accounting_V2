using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AutoUpdater
{
    /// <summary>
    /// the type of Hash to create
    /// </summary>
    internal enum HashType
    {
        MD5,
        SHA1,
        SHA512
    }
    /// <summary>
    /// class used  the generate hash sums of the files
    /// </summary>
    internal static class Hasher
    {
        /// <summary>
        /// gernerate a hash sum of the file
        /// </summary>
        /// <param name="filePath">the file to hash</param>
        /// <param name="algo">the type of hash</param>
        /// <returns>the computed hash</returns>
        internal static string Hashfile(string filePath, HashType algo)
        {
            switch (algo)
            {
                case HashType.MD5:
                    return MakeHashString(MD5.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
                case HashType.SHA1:
                    return MakeHashString(SHA1.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
                case HashType.SHA512:
                    return MakeHashString(SHA512.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
                default:
                    return "";
            }
        }
        /// <summary>
        /// converts byte[] to string
        /// </summary>
        /// <param name="hash">the hash to convert</param>
        /// <returns>hash as string</returns>
        private static string MakeHashString(byte[] hash)
        {
            StringBuilder s = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
            {
                s.Append(b.ToString("X2").ToLower());
            }
            return s.ToString();
        }
    }
}
