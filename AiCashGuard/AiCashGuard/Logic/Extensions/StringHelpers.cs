using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace AiCashGuard.Logic.Extensions
{
    public class StringHelpers
    {
        private const string _fakePassword = "cZsPg4OOSDG+HQADbiw+Uu0W2PJ4P2jBKn8fAbyStmc=";

        private static RijndaelManaged _cryptoProvider;
        private static readonly char QUERY_STRING_DELIMITER = '&';

        //128 bit encyption: DO NOT CHANGE
        private static readonly byte[] Key = {18, 19, 8, 24, 36, 22, 4, 22, 17, 5, 11,
                                             9, 13, 15, 06, 23};
        private static readonly byte[] IV = {14, 2, 16, 7, 5, 9, 17, 8, 4, 47, 16, 12,
                                            1, 32, 25, 18};

        static StringHelpers()
        {
            _cryptoProvider = new RijndaelManaged();
            _cryptoProvider.Mode = CipherMode.CBC;
            _cryptoProvider.Padding = PaddingMode.PKCS7;
        }

        public static string FakePassword
        {
            get
            {
                return _fakePassword;
            }
        }

        [DebuggerStepThrough]
        public static string Encrypt(string unencryptedString)
        {
            byte[] bytIn = ASCIIEncoding.ASCII.GetBytes(unencryptedString);

            // Create a MemoryStream
            MemoryStream ms = new MemoryStream();

            // Create Crypto Stream that encrypts a stream
            CryptoStream cs = new CryptoStream(ms,
                _cryptoProvider.CreateEncryptor(Key, IV),
                CryptoStreamMode.Write);

            // Write content into MemoryStream
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();

            byte[] bytOut = ms.ToArray();
            return Convert.ToBase64String(bytOut);
        }

        [DebuggerStepThrough]
        public static string Decrypt(string encryptedString)
        {
            if (encryptedString.Trim().Length != 0)
            {
                // Convert from Base64 to binary
                byte[] bytIn = Convert.FromBase64String(encryptedString);

                // Create a MemoryStream
                MemoryStream ms = new MemoryStream(bytIn, 0, bytIn.Length);

                // Create a CryptoStream that decrypts the data
                CryptoStream cs = new CryptoStream(ms,
                    _cryptoProvider.CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read);

                // Read the Crypto Stream
                StreamReader sr = new StreamReader(cs);

                return sr.ReadToEnd();
            }
            else
            {
                return string.Empty;
            }
        }

        [DebuggerStepThrough]
        public static NameValueCollection DecryptQueryString(string queryString)
        {
            if (queryString.Length != 0)
            {
                //Decode the string
                string decodedQueryString = HttpUtility.UrlDecode(queryString);

                //Decrypt the string
                string decryptedQueryString = StringHelpers.Decrypt(decodedQueryString);

                //Now split the string based on each parameter
                string[] actionQueryString = decryptedQueryString.Split(new char[] {
                QUERY_STRING_DELIMITER });

                NameValueCollection newQueryString = new NameValueCollection();

                //loop around for each name value pair.
                for (int index = 0; index < actionQueryString.Length; index++)
                {
                    string[] queryStringItem = actionQueryString[index].Split(new
                        char[] { '=' });
                    newQueryString.Add(queryStringItem[0], queryStringItem[1]);
                }

                return newQueryString;
            }
            else
            {
                //No query string was passed in.
                return null;
            }
        }

        [DebuggerStepThrough]
        public static string EncryptQueryString(NameValueCollection queryString)
        {
            //create a string for each value in the query string passed in.
            string tempQueryString = "";

            for (int index = 0; index < queryString.Count; index++)
            {
                tempQueryString += queryString.GetKey(index) + "=" +
                    queryString[index];

                if (index != queryString.Count - 1)
                {
                    tempQueryString += QUERY_STRING_DELIMITER;
                }
            }

            return EncryptQueryString(tempQueryString);
        }

        public static string EncryptQueryString(string queryString)
        {
            return HttpUtility.UrlEncode(StringHelpers.Encrypt(queryString));
        }
        public static int ConvertToInt(string key)
        {
            if (string.IsNullOrEmpty(key))
                return 0;
            else
                return Convert.ToInt32(key);
        }

    }
}
