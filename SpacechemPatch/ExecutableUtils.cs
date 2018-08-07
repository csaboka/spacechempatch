using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SpacechemPatch
{
    static class ExecutableUtils
    {
        private const string OriginalExeSHA1 = "mGvK5S+QaCd6d9WLVVvweqcOcuAzidc8gXoRdbyr304=";

        public static string GetDefaultPath()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    {
                        return @"C:\Program Files (x86)\Steam\steamapps\common\SpaceChem";
                    }
                case PlatformID.Unix:
                    {
                        return Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".steam/steam/steamapps/common/SpaceChem");
                    }
                default:
                    throw new Exception("Unsupported platform: " + Environment.OSVersion.Platform);
            }
        }

        public static bool IsOriginalExe(string exePath)
        {
            string hashString = String.Empty;
            try
            {
                using (var stream = File.OpenRead(exePath))
                {
                    var sha = SHA256.Create();
                    byte[] hash = sha.ComputeHash(stream);
                    hashString = Convert.ToBase64String(hash);
                }
            }
            catch (Exception) { }

            return (hashString == OriginalExeSHA1);
        }
    }
}
