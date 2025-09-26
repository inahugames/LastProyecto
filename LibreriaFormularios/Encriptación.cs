﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;

namespace SEG
{
    public static class Encriptación
    {
        public static byte[] Encriptar(string texto)
        {
            byte[] datos = Encoding.UTF8.GetBytes(texto);
            return ProtectedData.Protect(datos, null, DataProtectionScope.CurrentUser);
        }

        public static string Desencriptar(byte[] cifrado)
        {
            byte[] datos = ProtectedData.Unprotect(cifrado, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(datos);

        }
    }
}
