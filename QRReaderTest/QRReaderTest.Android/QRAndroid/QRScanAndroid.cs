using System.Threading.Tasks;
using QRReaderTest.QR;
using ZXing.Mobile;
using Xamarin.Forms;

[assembly: Dependency(typeof(QRReaderTest.Droid.QRAndroid.QRScanAndroid))]

namespace QRReaderTest.Droid.QRAndroid
{
    public class QRScanAndroid : IQRScan
    {
        public async Task<string> AsyncScan()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "QR Kodunu Tara",
                BottomText = "Lütfen Bekleyin",
            };

            MobileBarcodeScanner.Initialize(new Android.App.Application());
            var scanResult = await scanner.Scan(optionsCustom);

            if (scanResult != null)
                return scanResult.Text;
            else
                return "QR Bilgisi boş";
        }
    }
}