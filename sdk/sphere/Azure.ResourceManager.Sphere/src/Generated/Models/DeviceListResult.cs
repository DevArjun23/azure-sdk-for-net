// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Sphere;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// The response of a Device list operation.
    /// Serialized Name: DeviceListResult
    /// </summary>
    internal partial class DeviceListResult
    {
        /// <summary> Initializes a new instance of DeviceListResult. </summary>
        /// <param name="value">
        /// The Device items on this page
        /// Serialized Name: DeviceListResult.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DeviceListResult(IEnumerable<SphereDeviceData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DeviceListResult. </summary>
        /// <param name="value">
        /// The Device items on this page
        /// Serialized Name: DeviceListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The link to the next page of items
        /// Serialized Name: DeviceListResult.nextLink
        /// </param>
        internal DeviceListResult(IReadOnlyList<SphereDeviceData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The Device items on this page
        /// Serialized Name: DeviceListResult.value
        /// </summary>
        public IReadOnlyList<SphereDeviceData> Value { get; }
        /// <summary>
        /// The link to the next page of items
        /// Serialized Name: DeviceListResult.nextLink
        /// </summary>
        public Uri NextLink { get; }
    }
}
