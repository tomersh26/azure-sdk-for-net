// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// Represents all the operations for managing recommended actions on Azure
    /// SQL Server. Contains operations to retrieve recommended action and
    /// update its state.
    /// </summary>
    public partial interface IServerRecommendedActionOperations
    {
        /// <summary>
        /// Returns details of a recommended action.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL server.
        /// </param>
        /// <param name='advisorName'>
        /// The name of the Azure SQL Server advisor.
        /// </param>
        /// <param name='recommendedActionName'>
        /// The name of the Azure SQL Server recommended action.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a get recommended action request.
        /// </returns>
        Task<RecommendedActionGetResponse> GetAsync(string resourceGroupName, string serverName, string advisorName, string recommendedActionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns list of recommended actions for this advisor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL server.
        /// </param>
        /// <param name='advisorName'>
        /// The name of the Azure SQL Server advisor.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a list recommended actions request.
        /// </returns>
        Task<RecommendedActionListResponse> ListAsync(string resourceGroupName, string serverName, string advisorName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates recommended action state.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL server.
        /// </param>
        /// <param name='advisorName'>
        /// The name of the Azure SQL Server advisor.
        /// </param>
        /// <param name='recommendedActionName'>
        /// The name of the Azure SQL Server recommended action.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for updating recommended action state.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to an update recommended action request.
        /// </returns>
        Task<RecommendedActionUpdateResponse> UpdateAsync(string resourceGroupName, string serverName, string advisorName, string recommendedActionName, RecommendedActionUpdateParameters parameters, CancellationToken cancellationToken);
    }
}