using System;

namespace Booking.Common.Encryption
{
    public class CryptoSettings
    {
        public byte[] Key { get; set; }
        public byte[] IV { get; set; }
    }
}
