using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taskly.Shared.Pages
{
    public partial class WebVersionDownload
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string version { get; set; }
        public void GoToHome()
        {
            NavigationManager.NavigateTo("/");
        }
        public void GoToDownloads()
        {
            NavigationManager.NavigateTo("/downloads");
        }
        public void GoToVersions()
        {
            NavigationManager.NavigateTo("/versions");
        }
    }
}
