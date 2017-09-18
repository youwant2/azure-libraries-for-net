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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Disk update resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiskUpdateInner : ResourceUpdate
    {
        /// <summary>
        /// Initializes a new instance of the DiskUpdateInner class.
        /// </summary>
        public DiskUpdateInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskUpdateInner class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="osType">the Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="diskSizeGB">If creationData.createOption is Empty,
        /// this field is mandatory and it indicates the size of the VHD to
        /// create. If this field is present for updates or creation with other
        /// options, it indicates a resize. Resizes are only allowed if the
        /// disk is not attached to a running VM, and can only increase the
        /// disk's size.</param>
        /// <param name="encryptionSettings">Encryption settings for disk or
        /// snapshot</param>
        public DiskUpdateInner(IDictionary<string, string> tags = default(IDictionary<string, string>), DiskSku sku = default(DiskSku), OperatingSystemTypes? osType = default(OperatingSystemTypes?), int? diskSizeGB = default(int?), EncryptionSettings encryptionSettings = default(EncryptionSettings))
            : base(tags, sku)
        {
            OsType = osType;
            DiskSizeGB = diskSizeGB;
            EncryptionSettings = encryptionSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Operating System type. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OperatingSystemTypes? OsType { get; set; }

        /// <summary>
        /// Gets or sets if creationData.createOption is Empty, this field is
        /// mandatory and it indicates the size of the VHD to create. If this
        /// field is present for updates or creation with other options, it
        /// indicates a resize. Resizes are only allowed if the disk is not
        /// attached to a running VM, and can only increase the disk's size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets encryption settings for disk or snapshot
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionSettings")]
        public EncryptionSettings EncryptionSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EncryptionSettings != null)
            {
                EncryptionSettings.Validate();
            }
        }
    }
}
