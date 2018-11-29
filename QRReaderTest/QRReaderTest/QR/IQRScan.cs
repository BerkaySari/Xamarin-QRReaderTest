using System.Threading.Tasks;

namespace QRReaderTest.QR
{
    public interface IQRScan
    {
        Task<string> AsyncScan();
    }
}
