// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    ///   A representation of configuration data for a single Azure OpenAI chat extension. This will be used by a chat
    ///   completions request that should use Azure OpenAI chat extensions to augment the response behavior.
    ///   The use of this configuration is compatible only with Azure OpenAI.
    /// Please note <see cref="AzureChatExtensionConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureSearchChatExtensionConfiguration"/>, <see cref="AzureMachineLearningIndexChatExtensionConfiguration"/>, <see cref="AzureCosmosDBChatExtensionConfiguration"/>, <see cref="ElasticsearchChatExtensionConfiguration"/> and <see cref="PineconeChatExtensionConfiguration"/>.
    /// </summary>
    public abstract partial class AzureChatExtensionConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AzureChatExtensionConfiguration"/>. </summary>
        protected AzureChatExtensionConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatExtensionConfiguration"/>. </summary>
        /// <param name="type">
        ///   The label for the type of an Azure chat extension. This typically corresponds to a matching Azure resource.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureChatExtensionConfiguration(AzureChatExtensionType type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        ///   The label for the type of an Azure chat extension. This typically corresponds to a matching Azure resource.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// </summary>
        internal AzureChatExtensionType Type { get; set; }
    }
}
