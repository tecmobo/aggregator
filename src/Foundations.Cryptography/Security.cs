﻿using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Security;

namespace Foundations.Cryptography
{
    public static class Security
    {
        public static Guid CreateGuidFromData(string data)
        {
            var digest = new MD5Digest();

            var bytes = Encoding.UTF8.GetBytes(data);
            digest.BlockUpdate(bytes, 0, bytes.Length);

            var result = new byte[digest.GetDigestSize()];
            digest.DoFinal(result, 0);

            return new Guid(result);
        }

        /// <summary>
        /// Creates a 16 character a cryptographically strong string
        /// </summary>
        /// <returns></returns>
        public static string Create16CharacterCryptographicallyStrongString(
            CryptoStringTypeEnum stringType = CryptoStringTypeEnum.LowercaseAlphaNumeric)
        {
            //Per NIST truncating a SHA256 hash by taking the left most n bits is acceptable
            //http://nvlpubs.nist.gov/nistpubs/Legacy/SP/nistspecialpublication800-107r1.pdf
            return CreateCryptographicallyStrongString<Sha256Digest>(
                stringType)
                .Substring(0, 16);
        }

        /// <summary>
        /// Creates a 32 character  cryptographically strong string
        /// </summary>
        /// <returns></returns>
        public static string Create32CharacterCryptographicallyStrongString(
            CryptoStringTypeEnum stringType = CryptoStringTypeEnum.Base64AlphaNumeric)
        {
            //Per NIST truncating a SHA256 hash by taking the left most n bits is acceptable
            //http://nvlpubs.nist.gov/nistpubs/Legacy/SP/nistspecialpublication800-107r1.pdf
            return CreateCryptographicallyStrongString<Sha256Digest>(
                stringType)
                .Substring(0, 32);
        }

        /// <summary>
        /// Creates a cryptographically strong string with the given digest
        /// </summary>
        /// <typeparam name="TDigest">Hash type</typeparam>
        /// <param name="stringType">Filter to apply to string</param>
        /// <returns>A string with only the characters defined by stringType</returns>
        private static string CreateCryptographicallyStrongString<TDigest>(
            CryptoStringTypeEnum stringType)
            where TDigest : IDigest, new()
        {
            var randomBytes = BitConverter.GetBytes(
                new SecureRandom().NextInt());

            var digest = new TDigest();
            digest.BlockUpdate(
                randomBytes,
                0,
                randomBytes.Length);
            var randomDigest = new DigestRandomGenerator(digest);

            var cryptoData = new byte[digest.GetDigestSize()];
            randomDigest.NextBytes(cryptoData);

            var result = Convert.ToBase64String(cryptoData);


            switch (stringType)
            {
                case CryptoStringTypeEnum.Base64AlphaNumeric:
                    return result
                        .Replace('/', '_')
                        .Replace('+', '-');
                //Note that this substitution reduces the integrity of the strong string
                //but is necessary in certain URL scenarios
                case CryptoStringTypeEnum.LowercaseAlphaNumeric:
                    return result
                        .Replace('/', 'a')
                        .Replace('+', 'b')
                        .ToLower();
                case CryptoStringTypeEnum.Base64:
                default:
                    return result;
            }
        }

        /// <summary>
        /// Performs a SHA1 Hash
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">SHA value</param>
        /// <returns>Base 64 encoded string representing the hash</returns>
        public static string Sha1Hash(
            string key, 
            string value)
        {
            var hmac = new HMac(new Sha1Digest());
            hmac.Init(new KeyParameter(Encoding.UTF8.GetBytes(key)));
            var result = new byte[hmac.GetMacSize()];
            var bytes = Encoding.UTF8.GetBytes(value);

            hmac.BlockUpdate(bytes, 0, bytes.Length);
            hmac.DoFinal(result, 0);

            return Convert.ToBase64String(result);
        }
    }
}
