using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taskly.Shared.Layout
{
    public partial class WebNavMenu
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public void GoToHome()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
