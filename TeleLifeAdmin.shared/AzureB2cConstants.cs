using System;
using System.Collections.Generic;
using System.Text;

namespace TeleLifeAdmin.shared
{
    public class AzureB2cConstants
    {
        public static readonly string TenantId = "telelifeadmin.onmicrosoft.com";
        public static readonly string TenantName = "telelifeadmin";
        public static readonly string ClientId = "91ea46f0-1439-4d69-b586-619ce51720cb";
        public static readonly string SignInPolicy = "B2C_1_TelelifeAdminSignUpIn";
        public static readonly string IosKeychainSecurityGroup = "com.microsoft.cmb2cauthorization";
        public static readonly string AuthorityBase = $"https://{TenantName}.b2clogin.com/tfp/{TenantId}/";
        public static readonly string AuthoritySignIn = $"{AuthorityBase}{SignInPolicy}";
        public static readonly string[] Scopes = new string[] { "openid", "offline_access" };
        public static readonly string TwitchClientId = "kdmjkggyqxq6izqdyouyl4k8pqelll";
    }
}
