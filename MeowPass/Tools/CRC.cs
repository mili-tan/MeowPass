using System;

namespace MeowPass
{
    class CRC
    {
        public static byte[] CRC16(byte[] data)
        {
            byte CRC16Lo = 0;
            byte CRC16Hi = 0;
            byte CL = 0;
            byte CH = 0;
            byte SaveHi = 0;
            byte SaveLo = 0;
            short Flag = 0;
            byte[] ReturnData = new byte[1 + 1];
            CRC16Lo = (byte)0xFF;
            CRC16Hi = (byte)0xFF;
            CL = (byte)0x1;
            CH = (byte)0xA0;
            for (int i = 0; i <= data.Length - 3; i++)
            {
                CRC16Lo = Convert.ToByte(CRC16Lo ^ data[i]);
                for (Flag = (short)0;
                Flag <= 7.0;
                Flag = Convert.ToInt16(Flag + 1))
                {
                    SaveHi = CRC16Hi;
                    SaveLo = CRC16Lo;
                    CRC16Hi = Convert.ToByte(CRC16Hi / 2);
                    CRC16Lo = Convert.ToByte(CRC16Lo / 2);
                    if ((SaveHi & 0x1) == 0x1)
                    {
                        CRC16Lo = Convert.ToByte(CRC16Lo | 0x80);
                    }
                    if ((SaveLo & 0x1) == 0x1)
                    {
                        CRC16Hi = Convert.ToByte(CRC16Hi ^ CH);
                        CRC16Lo = Convert.ToByte(CRC16Lo ^ CL);
                    }
                }
            }
            ReturnData[0] = CRC16Lo;
            ReturnData[1] = CRC16Hi;
            return ReturnData;
        }
    }
}
