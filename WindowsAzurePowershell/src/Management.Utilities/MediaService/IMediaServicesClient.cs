﻿// ----------------------------------------------------------------------------------
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Utilities.MediaService.Services.MediaServicesEntities;

namespace Microsoft.WindowsAzure.Management.Utilities.MediaService
{
    /// <summary>
    ///     Defines interface to communicate with Azure Media Services REST API
    /// </summary>
    public interface IMediaServicesClient
    {
        /// <summary>
        ///     Gets the media service accounts async.
        /// </summary>
        /// <returns></returns>
        Task<List<MediaServiceAccount>> GetMediaServiceAccountsAsync();

        /// <summary>
        ///     Gets the media service account details async.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        Task<MediaServiceAccountDetails> GetMediaServiceAsync(string name);

        /// <summary>
        ///     Create new azure media service async.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<AccountCreationResult> CreateNewAzureMediaServiceAsync(AccountCreationRequest request);
    }
}