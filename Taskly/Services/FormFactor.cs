using Taskly.Shared.Services;

namespace Taskly.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetDeviceType()
        {
#if ANDROID
            return "android";
#elif IOS
              return "ios";
#elif WINDOWS
                return "windows";
#elif MACCATALYST
                return "maccatalyst";
#endif
        }

        public string GetFormFactor()
        {
            return DeviceInfo.Idiom.ToString();
        }

        public string GetPlatform()
        {
            return DeviceInfo.Platform.ToString() + " - " + DeviceInfo.VersionString;
        }

    }
}
