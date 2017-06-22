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
using Microsoft.Azure.Management.Sql.LegacySdk;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class DatabaseAdvisorOperationsExtensions
    {
        /// <summary>
        /// Returns details of a Database Advisor.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL database.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL database advisor.
        /// </param>
        /// <param name='expand'>
        /// Optional. The comma separated list of child objects that we want to
        /// expand on in response. NULL if expand is not required.
        /// </param>
        /// <returns>
        /// Represents the response to a get advisor request.
        /// </returns>
        public static AdvisorGetResponse Get(this IDatabaseAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName, string advisorName, string expand)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseAdvisorOperations)s).GetAsync(resourceGroupName, serverName, databaseName, advisorName, expand);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns details of a Database Advisor.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL database.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL database advisor.
        /// </param>
        /// <param name='expand'>
        /// Optional. The comma separated list of child objects that we want to
        /// expand on in response. NULL if expand is not required.
        /// </param>
        /// <returns>
        /// Represents the response to a get advisor request.
        /// </returns>
        public static Task<AdvisorGetResponse> GetAsync(this IDatabaseAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName, string advisorName, string expand)
        {
            return operations.GetAsync(resourceGroupName, serverName, databaseName, advisorName, expand, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns list of Advisors for the Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL database.
        /// </param>
        /// <param name='expand'>
        /// Optional. The comma separated list of child objects that we want to
        /// expand on in response. NULL if expand is not required.
        /// </param>
        /// <returns>
        /// Represents the response to a list sql azure database advisors
        /// request.
        /// </returns>
        public static AdvisorListResponse List(this IDatabaseAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName, string expand)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseAdvisorOperations)s).ListAsync(resourceGroupName, serverName, databaseName, expand);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns list of Advisors for the Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL database.
        /// </param>
        /// <param name='expand'>
        /// Optional. The comma separated list of child objects that we want to
        /// expand on in response. NULL if expand is not required.
        /// </param>
        /// <returns>
        /// Represents the response to a list sql azure database advisors
        /// request.
        /// </returns>
        public static Task<AdvisorListResponse> ListAsync(this IDatabaseAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName, string expand)
        {
            return operations.ListAsync(resourceGroupName, serverName, databaseName, expand, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the auto-execute status for this Advisor.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL Database advisor.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for updating auto-execute status
        /// of an Advisor
        /// </param>
        /// <returns>
        /// Represents the response to a update advisor request.
        /// </returns>
        public static AdvisorUpdateResponse Update(this IDatabaseAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName, string advisorName, AdvisorUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseAdvisorOperations)s).UpdateAsync(resourceGroupName, serverName, databaseName, advisorName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the auto-execute status for this Advisor.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL Database advisor.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for updating auto-execute status
        /// of an Advisor
        /// </param>
        /// <returns>
        /// Represents the response to a update advisor request.
        /// </returns>
        public static Task<AdvisorUpdateResponse> UpdateAsync(this IDatabaseAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName, string advisorName, AdvisorUpdateParameters parameters)
        {
            return operations.UpdateAsync(resourceGroupName, serverName, databaseName, advisorName, parameters, CancellationToken.None);
        }
    }
}