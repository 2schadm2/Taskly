using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taskly.Shared.Pages
{
    public partial class Versions
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public void GoToHome()
        {
            NavigationManager.NavigateTo("/");
        }
        public void GoToDownloads()
        {
            NavigationManager.NavigateTo("/downloads");
        }
    }
}
