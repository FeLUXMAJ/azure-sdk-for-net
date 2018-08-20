// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The platform properties against which the build has to happen.
    /// </summary>
    public partial class PlatformProperties
    {
        /// <summary>
        /// Initializes a new instance of the PlatformProperties class.
        /// </summary>
        public PlatformProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlatformProperties class.
        /// </summary>
        /// <param name="osType">The operating system type required for the
        /// build. Possible values include: 'Windows', 'Linux'</param>
        /// <param name="cpu">The CPU configuration in terms of number of cores
        /// required for the build.</param>
        public PlatformProperties(string osType, int? cpu = default(int?))
        {
            OsType = osType;
            Cpu = cpu;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the operating system type required for the build.
        /// Possible values include: 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the CPU configuration in terms of number of cores
        /// required for the build.
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public int? Cpu { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OsType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsType");
            }
        }
    }
}