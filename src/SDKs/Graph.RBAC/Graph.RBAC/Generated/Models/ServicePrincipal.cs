// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Active Directory service principal information.
    /// </summary>
    public partial class ServicePrincipal : DirectoryObject
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipal class.
        /// </summary>
        public ServicePrincipal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipal class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="objectId">The object ID.</param>
        /// <param name="deletionTimestamp">The time at which the directory
        /// object was deleted.</param>
        /// <param name="displayName">The display name of the service
        /// principal.</param>
        /// <param name="appId">The application ID.</param>
        /// <param name="servicePrincipalNames">A collection of service
        /// principal names.</param>
        public ServicePrincipal(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string objectId = default(string), System.DateTime? deletionTimestamp = default(System.DateTime?), string displayName = default(string), string appId = default(string), IList<string> servicePrincipalNames = default(IList<string>))
            : base(additionalProperties, objectId, deletionTimestamp)
        {
            DisplayName = displayName;
            AppId = appId;
            ServicePrincipalNames = servicePrincipalNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the service principal.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the application ID.
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets a collection of service principal names.
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalNames")]
        public IList<string> ServicePrincipalNames { get; set; }

    }
}