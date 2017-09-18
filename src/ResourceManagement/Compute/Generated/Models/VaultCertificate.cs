// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Azure.Management.Compute.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a single certificate reference in a Key Vault, and where the
    /// certificate should reside on the VM.
    /// </summary>
    public partial class VaultCertificate
    {
        /// <summary>
        /// Initializes a new instance of the VaultCertificate class.
        /// </summary>
        public VaultCertificate()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultCertificate class.
        /// </summary>
        /// <param name="certificateUrl">This is the URL of a certificate that
        /// has been uploaded to Key Vault as a secret. For adding a secret to
        /// the Key Vault, see [Add a key or secret to the key
        /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be It is the Base64
        /// encoding of the following JSON Object which is encoded in UTF-8:
        /// &lt;br&gt;&lt;br&gt; {&lt;br&gt;
        /// "data":"&lt;Base64-encoded-certificate&gt;",&lt;br&gt;
        /// "dataType":"pfx",&lt;br&gt;
        /// "password":"&lt;pfx-file-password&gt;"&lt;br&gt;}</param>
        /// <param name="certificateStore">For Windows VMs, specifies the
        /// certificate store on the Virtual Machine to which the certificate
        /// should be added. The specified certificate store is implicitly in
        /// the LocalMachine account. &lt;br&gt;&lt;br&gt;For Linux VMs, the
        /// certificate file is placed under the /var/lib/waagent directory,
        /// with the file name &lt;UppercaseThumbprint&gt;.crt for the X509
        /// certificate file and &lt;UppercaseThumbpring&gt;.prv for private
        /// key. Both of these files are .pem formatted.</param>
        public VaultCertificate(string certificateUrl = default(string), string certificateStore = default(string))
        {
            CertificateUrl = certificateUrl;
            CertificateStore = certificateStore;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this is the URL of a certificate that has been
        /// uploaded to Key Vault as a secret. For adding a secret to the Key
        /// Vault, see [Add a key or secret to the key
        /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be It is the Base64
        /// encoding of the following JSON Object which is encoded in UTF-8:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; {&amp;lt;br&amp;gt;
        /// "data":"&amp;lt;Base64-encoded-certificate&amp;gt;",&amp;lt;br&amp;gt;
        /// "dataType":"pfx",&amp;lt;br&amp;gt;
        /// "password":"&amp;lt;pfx-file-password&amp;gt;"&amp;lt;br&amp;gt;}
        /// </summary>
        [JsonProperty(PropertyName = "certificateUrl")]
        public string CertificateUrl { get; set; }

        /// <summary>
        /// Gets or sets for Windows VMs, specifies the certificate store on
        /// the Virtual Machine to which the certificate should be added. The
        /// specified certificate store is implicitly in the LocalMachine
        /// account. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;For Linux VMs, the
        /// certificate file is placed under the /var/lib/waagent directory,
        /// with the file name &amp;lt;UppercaseThumbprint&amp;gt;.crt for the
        /// X509 certificate file and &amp;lt;UppercaseThumbpring&amp;gt;.prv
        /// for private key. Both of these files are .pem formatted.
        /// </summary>
        [JsonProperty(PropertyName = "certificateStore")]
        public string CertificateStore { get; set; }

    }
}
