// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents applicable recovery vm sizes properties.
    /// </summary>
    public partial class TargetComputeSizeProperties
    {
        /// <summary>
        /// Initializes a new instance of the TargetComputeSizeProperties
        /// class.
        /// </summary>
        public TargetComputeSizeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TargetComputeSizeProperties
        /// class.
        /// </summary>
        /// <param name="name">Target compute size name.</param>
        /// <param name="friendlyName">Target compute size display
        /// name.</param>
        /// <param name="cpuCoresCount">The maximum cpu cores count supported
        /// by target compute size.</param>
        /// <param name="memoryInGB">The maximum memory in GB supported by
        /// target compute size.</param>
        /// <param name="maxDataDiskCount">The maximum data disks count
        /// supported by target compute size.</param>
        /// <param name="maxNicsCount">The maximum Nics count supported by
        /// target compute size.</param>
        /// <param name="errors">The reasons why the target compute size is not
        /// applicable for the protected item.</param>
        /// <param name="highIopsSupported">The value indicating whether the
        /// target compute size supports high Iops.</param>
        public TargetComputeSizeProperties(string name = default(string), string friendlyName = default(string), int? cpuCoresCount = default(int?), double? memoryInGB = default(double?), int? maxDataDiskCount = default(int?), int? maxNicsCount = default(int?), IList<ComputeSizeErrorDetails> errors = default(IList<ComputeSizeErrorDetails>), string highIopsSupported = default(string))
        {
            Name = name;
            FriendlyName = friendlyName;
            CpuCoresCount = cpuCoresCount;
            MemoryInGB = memoryInGB;
            MaxDataDiskCount = maxDataDiskCount;
            MaxNicsCount = maxNicsCount;
            Errors = errors;
            HighIopsSupported = highIopsSupported;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets target compute size name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets target compute size display name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the maximum cpu cores count supported by target
        /// compute size.
        /// </summary>
        [JsonProperty(PropertyName = "cpuCoresCount")]
        public int? CpuCoresCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum memory in GB supported by target compute
        /// size.
        /// </summary>
        [JsonProperty(PropertyName = "memoryInGB")]
        public double? MemoryInGB { get; set; }

        /// <summary>
        /// Gets or sets the maximum data disks count supported by target
        /// compute size.
        /// </summary>
        [JsonProperty(PropertyName = "maxDataDiskCount")]
        public int? MaxDataDiskCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum Nics count supported by target compute
        /// size.
        /// </summary>
        [JsonProperty(PropertyName = "maxNicsCount")]
        public int? MaxNicsCount { get; set; }

        /// <summary>
        /// Gets or sets the reasons why the target compute size is not
        /// applicable for the protected item.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<ComputeSizeErrorDetails> Errors { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the target compute size
        /// supports high Iops.
        /// </summary>
        [JsonProperty(PropertyName = "highIopsSupported")]
        public string HighIopsSupported { get; set; }

    }
}