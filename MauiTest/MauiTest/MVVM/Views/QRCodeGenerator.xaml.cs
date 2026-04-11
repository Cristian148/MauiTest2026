using QRCoder;

namespace MauiTest.MVVM.Views;

public partial class QRCodeGenerator : ContentPage
{
	public QRCodeGenerator()
	{
		InitializeComponent();
        //https://www.youtube.com/watch?v=vkw3-6UvCGQ
	}
	private void OnGenerateQRCodeClicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(InputText.Text))
		{
			DisplayAlert("Aviso", "Por favor, ingrese la dirección para generar el Códig QR.", "OK");
			return;
		}
		// Generate a scalable black and white SVG QR code
		QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
		QRCoder.QRCodeData qrCodeData = qrGenerator.CreateQrCode(InputText.Text, QRCoder.QRCodeGenerator.ECCLevel.L);
		QRCoder.PngByteQRCode pngRenderer = new QRCoder.PngByteQRCode(qrCodeData);
		byte[] qrCodeImage = pngRenderer.GetGraphic(20);
		QRCodeImage.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeImage));
	}
}