﻿// --------------------------------------------------------------------------------
// Copyright (c) Christo du Toit. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// FREE TO USE TO HELP SHARE THE GOSPEL
// Mark 16:15 NIV "Go into all the world and preach the gospel to all creation."
// https://mark.bible/mark-16-15 
// --------------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace G2H.Portal.Web.Views.Bases
{
    public partial class ImageBase : ComponentBase
    {
        [Parameter]
        public string Source { get; set; }

        [Parameter]
        public string AlternativeText { get; set; }

        [Parameter]
        public string Width { get; set; }

        [Parameter]
        public string Height { get; set; }

        public void SetSource(string source)
        {
            Source = source;
            InvokeAsync(StateHasChanged);
        }

        public void SetAlternativeText(string alternativeText)
        {
            AlternativeText = alternativeText;
            InvokeAsync(StateHasChanged);
        }
    }
}
