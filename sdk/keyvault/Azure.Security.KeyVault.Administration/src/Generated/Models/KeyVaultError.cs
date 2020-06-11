// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> The key vault error exception. </summary>
    internal partial class KeyVaultError
    {
        /// <summary> Initializes a new instance of KeyVaultError. </summary>
        internal KeyVaultError()
        {
        }

        /// <summary> Initializes a new instance of KeyVaultError. </summary>
        /// <param name="error"> The key vault server error. </param>
        internal KeyVaultError(Error error)
        {
            Error = error;
        }

        /// <summary> The key vault server error. </summary>
        public Error Error { get; }
    }
}
