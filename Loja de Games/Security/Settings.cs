using Microsoft.AspNetCore.DataProtection;

namespace Loja_de_Games.Security
{
    public class Settings
    {
        public static string secret = "dd9eeef8a9830f5bf7d1d16a4ce77fde4c786a66c4bfacc0cf93438411c2f509";
        public static string Secret { get => secret; set => secret = value; }
    }
}
