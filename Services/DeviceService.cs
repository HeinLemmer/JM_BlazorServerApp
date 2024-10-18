using JendaMarkBlazorApp.Data;

namespace JendaMarkBlazorApp.Services
{
    class DeviceService
    {
        private readonly List<Device> devices = new List<Device>();

        public List<Device> GetDevices()
        {
            return devices;
        }

        
    }
}
