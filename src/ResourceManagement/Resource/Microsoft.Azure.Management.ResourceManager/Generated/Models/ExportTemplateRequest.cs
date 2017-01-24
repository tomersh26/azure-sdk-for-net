// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// Export resource group template request parameters.
    /// </summary>
    public partial class ExportTemplateRequest
    {
        /// <summary>
        /// Initializes a new instance of the ExportTemplateRequest class.
        /// </summary>
        public ExportTemplateRequest() { }

        /// <summary>
        /// Initializes a new instance of the ExportTemplateRequest class.
        /// </summary>
        /// <param name="resources">The ids of the resources. The only
        /// supported string currently is '*' (all resources). Future api
        /// updates will support exporting specific resources.</param>
        /// <param name="options">The export template options. Supported
        /// values include 'IncludeParameterDefaultValue', 'IncludeComments'
        /// or 'IncludeParameterDefaultValue, IncludeComments</param>
        public ExportTemplateRequest(System.Collections.Generic.IList<string> resources = default(System.Collections.Generic.IList<string>), string options = default(string))
        {
            Resources = resources;
            Options = options;
        }

        /// <summary>
        /// Gets or sets the ids of the resources. The only supported string
        /// currently is '*' (all resources). Future api updates will support
        /// exporting specific resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>
        /// Gets or sets the export template options. Supported values include
        /// 'IncludeParameterDefaultValue', 'IncludeComments' or
        /// 'IncludeParameterDefaultValue, IncludeComments
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "options")]
        public string Options { get; set; }

    }
}