using System;
using static Data_access.DLMS_Services;

namespace DLMS.Services
{
    // Example usage
    public class Program
    {
        public static void Main()
        {
            // Create meter objects
            MeterObject[] meterObjects = new MeterObject[]
            {
                new MeterObject("Voltage", DlmsService.obis_voltage, 220),
                new MeterObject("Energy", DlmsService.obis_energy, 1500)
               
            };

            // Create DLMS service instance
            DlmsService dlms = new DlmsService(meterObjects);

            // GET example
            dlms.DlmsGet(DlmsService.obis_voltage);
            dlms.DlmsGet(DlmsService.obis_energy);

            // SET example
            dlms.DlmsSet(DlmsService.obis_voltage, 240);
            dlms.DlmsSet(DlmsService.obis_voltage, 130);

            // ACTION example
            dlms.DlmsAction(DlmsService.obis_energy, "RESET");

        }
    }
}
