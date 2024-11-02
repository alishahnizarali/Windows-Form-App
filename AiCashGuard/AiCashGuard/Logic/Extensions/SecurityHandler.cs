using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Web;

namespace AiCashGuard.Logic.Extensions
{
    public class SecurityHandler
    {
        public static string Decrypt(string key)
        {
            if (string.IsNullOrEmpty(key) || key.ToLower() == "null" || key.ToLower() == "undefined" || key == "0")
            {
                return "";
            }

            key = key.Replace(" ", "+");
            key = System.Web.HttpUtility.UrlEncode(key);
            NameValueCollection quer = StringHelpers.DecryptQueryString(key);
            string id = Convert.ToString(quer[0]);
            return id;
        }

        [DebuggerStepThrough]
        public static string Encrypt(int key)
        {
            if (key > 0)
            {
                return StringHelpers.Encrypt("id=" + key.ToString());
            }

            return string.Empty;
        }

        public static string Encrypt(string key)
        {
            return StringHelpers.Encrypt("token=" + key.ToString());
        }

        public static string GetEncryptedData(Dictionary<string, string> list)
        {
            var items = new List<string>();

            foreach (var entry in list)
            {
                items.Add(entry.Key + "=" + (entry.Value != null && !string.IsNullOrEmpty(entry.Value.ToString()) ? entry.Value : ""));
            }

            return StringHelpers.Encrypt(string.Join("&", items));
        }

        public static NameValueCollection DecryptStringCollection(string key)
        {
            if (string.IsNullOrEmpty(key) || key.ToLower() == "null" || key.ToLower() == "undefined")
            {
                return null;
            }

            key = key.Replace(" ", "+");
            key = key.Replace("\"", "");
            key = HttpUtility.UrlEncode(key);
            NameValueCollection quer = StringHelpers.DecryptQueryString(key);
            return quer;
        }
    }
}
