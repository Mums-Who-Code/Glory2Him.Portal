﻿// --------------------------------------------------------------------------------
// Copyright (c) Christo du Toit. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// FREE TO USE TO HELP SHARE THE GOSPEL
// Mark 16:15 NIV "Go into all the world and preach the gospel to all creation."
// https://mark.bible/mark-16-15 
// --------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using G2H.Portal.Web.Models.PostTypes;

namespace G2H.Portal.Web.Brokers.Apis
{
    public partial class ApiBroker
    {
        private const string postTypesRelativeUrl = "api/postTypes";

        public async ValueTask<List<PostType>> GetAllPostTypesAsync() =>
            await this.GetAsync<List<PostType>>(postTypesRelativeUrl);

        public async ValueTask<PostType> GetPostTypeByIdAsync(Guid postTypeId) =>
            await this.GetAsync<PostType>($"{postTypesRelativeUrl}/{postTypeId}");
    }
}