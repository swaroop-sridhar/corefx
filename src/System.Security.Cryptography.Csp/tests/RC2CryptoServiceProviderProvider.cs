// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Cryptography.Encryption.RC2.Tests
{
    using RC2 = System.Security.Cryptography.RC2;

    public class RC2CryptoServiceProviderProvider : IRC2Provider
    {
        public RC2 Create()
        {
            return new RC2CryptoServiceProvider();
        }
    }

    public partial class RC2Factory
    {
        private static readonly IRC2Provider s_provider = new RC2CryptoServiceProviderProvider();
    }
}
