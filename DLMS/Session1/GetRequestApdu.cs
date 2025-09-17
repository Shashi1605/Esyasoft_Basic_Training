using DLMS_get_request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GetRequestApdu
{
    public static byte[] CreateGetRequest(ObisCode obis, ushort classId, byte attributeId)
    {
        List<byte> apdu = new List<byte>();

        
        apdu.Add(0xC0); 
        apdu.Add(0x01); 
                        
        apdu.Add(0x01); 

        
        apdu.Add((byte)(classId >> 8)); 
        apdu.Add((byte)(classId & 0xFF)); 

        
        apdu.AddRange(obis.ToByteArray());

        apdu.Add(attributeId);

        apdu.Add(0x00);

        return apdu.ToArray();
    }
}