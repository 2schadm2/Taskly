namespace Taskly.Shared.Services
{
    public interface IFormFactor
    {
        public string GetFormFactor();
        public string GetPlatform();
        public string GetDeviceType();
    }
}
