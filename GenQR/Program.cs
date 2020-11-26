using System;
using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;

namespace GenQR
{
    class Program
    {
        static void Main(string[] args)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save("qrtest.png", ImageFormat.Png);
        }
    }
}
