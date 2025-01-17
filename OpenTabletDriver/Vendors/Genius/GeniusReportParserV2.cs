using OpenTabletDriver.Plugin.Tablet;
using OpenTabletDriver.Tablet;

namespace OpenTabletDriver.Vendors.Genius
{
    public class GeniusReportParserV2 : IReportParser<IDeviceReport>
    {
        public IDeviceReport Parse(byte[] data)
        {
            return data[0] switch
            {
                0x02 => new GeniusTabletReport(data),
                0x05 => new GeniusButtonStripAuxReport(data),
                _ => new DeviceReport(data)
            };
        }
    }
}
