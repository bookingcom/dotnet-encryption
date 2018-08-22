namespace Booking.Common.Encryption
{
    public interface IEncryptor
    {
        string Decrypt(byte[] input);
        byte[] Encrypt(string json);
    }
}