﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public static class Genereta
    {
        public static string Decrypt(string encrypt)
        {
            using var tripleDESCryptoService = new TripleDESCryptoServiceProvider();
            using var hashMD5Provider = new MD5CryptoServiceProvider();
            var byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes("t4535634ljkhşkhylmbn...%^^2354345"));
            tripleDESCryptoService.Key = byteHash;
            tripleDESCryptoService.Mode = CipherMode.ECB;
            var data = Convert.FromBase64String(encrypt);
            return Encoding.UTF8.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));
        }
    }
}
