using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace JendaMarkBlazorApp.Data
{
    [TypeConverter(typeof(EnumConverter))]
    class Operation
    {
        public int OperationID { get; set; }
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }
        public byte[] ImageData { get; set; }
        public List<Device> Devices { get; set; }
    }
    [TypeConverter(typeof(EnumConverter))]
    class Device
    {
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public string DeviceType { get; set; }
    }
    [TypeConverter(typeof(EnumConverter))]
    enum DeviceType
    {
        BarcodeScanner,
        Printer,
        Camera,
        SocketTray
    }
}
