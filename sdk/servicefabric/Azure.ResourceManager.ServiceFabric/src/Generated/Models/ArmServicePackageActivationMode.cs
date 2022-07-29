// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// The activation Mode of the service package
    /// Serialized Name: ArmServicePackageActivationMode
    /// </summary>
    public readonly partial struct ArmServicePackageActivationMode : IEquatable<ArmServicePackageActivationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArmServicePackageActivationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArmServicePackageActivationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SharedProcessValue = "SharedProcess";
        private const string ExclusiveProcessValue = "ExclusiveProcess";

        /// <summary>
        /// Indicates the application package activation mode will use shared process.
        /// Serialized Name: ArmServicePackageActivationMode.SharedProcess
        /// </summary>
        public static ArmServicePackageActivationMode SharedProcess { get; } = new ArmServicePackageActivationMode(SharedProcessValue);
        /// <summary>
        /// Indicates the application package activation mode will use exclusive process.
        /// Serialized Name: ArmServicePackageActivationMode.ExclusiveProcess
        /// </summary>
        public static ArmServicePackageActivationMode ExclusiveProcess { get; } = new ArmServicePackageActivationMode(ExclusiveProcessValue);
        /// <summary> Determines if two <see cref="ArmServicePackageActivationMode"/> values are the same. </summary>
        public static bool operator ==(ArmServicePackageActivationMode left, ArmServicePackageActivationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArmServicePackageActivationMode"/> values are not the same. </summary>
        public static bool operator !=(ArmServicePackageActivationMode left, ArmServicePackageActivationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArmServicePackageActivationMode"/>. </summary>
        public static implicit operator ArmServicePackageActivationMode(string value) => new ArmServicePackageActivationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArmServicePackageActivationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArmServicePackageActivationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
