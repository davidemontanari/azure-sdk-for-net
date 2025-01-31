// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownTargetRollingWindowSize. </summary>
    internal partial class UnknownTargetRollingWindowSize : TargetRollingWindowSize
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTargetRollingWindowSize"/>. </summary>
        /// <param name="mode"> [Required] TargetRollingWindowSiz detection mode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownTargetRollingWindowSize(TargetRollingWindowSizeMode mode, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(mode, serializedAdditionalRawData)
        {
            Mode = mode;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownTargetRollingWindowSize"/> for deserialization. </summary>
        internal UnknownTargetRollingWindowSize()
        {
        }
    }
}
