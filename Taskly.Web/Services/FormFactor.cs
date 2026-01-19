using Taskly.Shared.Services;

namespace Taskly.Web.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetDeviceType()
        {
            return "web";
        }

        public string GetFormFactor()
        {
            return "Web";
        }

        public string GetPlatform()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
