//using Android.Graphics;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace MauiTest.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public CommandsViewModel()
        {
        }

        public string SearchTerm { get; set; }

        public ICommand ClickCommand => new Command(() => App.Current.MainPage.DisplayAlert("Title", SearchCommand2(), "Ok"));

        public string SearchCommand2()
        {
            string width = "200";
            string height = "200";
            string code = "https://www.google.com";
            //
            ////https://stackoverflow.com/questions/7020136/free-c-sharp-qr-code-generator
            //var url = string.Format("http://chart.apis.google.com/chart?cht=qr&chs={1}x{2}&chl={0}", code, width, height);
            //WebResponse responseWR = default(WebResponse);
            //Stream remoteStream = default(Stream);
            //StreamReader readStream = default(StreamReader);
            //WebRequest request = WebRequest.Create(url);
            //responseWR = request.GetResponse();
            //remoteStream = responseWR.GetResponseStream();
            //readStream = new StreamReader(remoteStream);
            //System.Drawing.Image img = System.Drawing.Image.FromStream(remoteStream);
            //img.Save("c:/QRCode/" + txtCode.Text + ".png");
            //responseWR.Close();
            //remoteStream.Close();
            //readStream.Close();
            //txtCode.Text = string.Empty;
            //txtWidth.Text = string.Empty;
            //txtHeight.Text = string.Empty;
            //lblMsg.Text = "The QR Code generated successfully";

            //segundo ejemplo
            //QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
            //QRCode qrCode = new QRCode(qrCodeData);
            //Bitmap qrCodeImage = qrCode.GetGraphic(20);
            //pictureBox1.Image = qrCodeImage;

            // Generate a scalable black and white SVG QR code
            using var qrCodeData = QRCodeGenerator.GenerateQrCode(SearchTerm, QRCodeGenerator.ECCLevel.Q);
            using var svgRenderer = new SvgQRCode(qrCodeData);
            string svg = svgRenderer.GetGraphic();
            //string svg = "dddd";
            return svg;
            //return new Command(() => App.Current.MainPage.DisplayAlert("Busqueda", $"Buscaste: {SearchTerm}", "Ok"));   
        }



        //public ICommand SearchCommand()
        //{
        //    string width = "200";
        //    string height = "200";
        //    string code = "https://www.google.com";
        //    //
        //    ////https://stackoverflow.com/questions/7020136/free-c-sharp-qr-code-generator
        //    //var url = string.Format("http://chart.apis.google.com/chart?cht=qr&chs={1}x{2}&chl={0}", code, width, height);
        //    //WebResponse responseWR = default(WebResponse);
        //    //Stream remoteStream = default(Stream);
        //    //StreamReader readStream = default(StreamReader);
        //    //WebRequest request = WebRequest.Create(url);
        //    //responseWR = request.GetResponse();
        //    //remoteStream = responseWR.GetResponseStream();
        //    //readStream = new StreamReader(remoteStream);
        //    //System.Drawing.Image img = System.Drawing.Image.FromStream(remoteStream);
        //    //img.Save("c:/QRCode/" + txtCode.Text + ".png");
        //    //responseWR.Close();
        //    //remoteStream.Close();
        //    //readStream.Close();
        //    //txtCode.Text = string.Empty;
        //    //txtWidth.Text = string.Empty;
        //    //txtHeight.Text = string.Empty;
        //    //lblMsg.Text = "The QR Code generated successfully";

        //    //segundo ejemplo
        //    //QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //    //QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
        //    //QRCode qrCode = new QRCode(qrCodeData);
        //    //Bitmap qrCodeImage = qrCode.GetGraphic(20);
        //    //pictureBox1.Image = qrCodeImage;

        //    // Generate a scalable black and white SVG QR code
        //    //using var qrCodeData = QRCodeGenerator.GenerateQrCode(SearchTerm, QRCodeGenerator.ECCLevel.Q);
        //    //using var svgRenderer = new SvgQRCode(qrCodeData);
        //    //string svg = svgRenderer.GetGraphic();
        //    string svg = "dddd";
        //    return new Command(() => App.Current.MainPage.DisplayAlert("Busqueda", $"Buscaste: {SearchTerm}\n\n{svg}", "Ok"));
        //    //return new Command(() => App.Current.MainPage.DisplayAlert("Busqueda", $"Buscaste: {SearchTerm}", "Ok"));   
        //} 

        //=> new Command(() => App.Current.MainPage.DisplayAlert("Busqueda", $"Buscaste: {SearchTerm}", "Ok"));
    }
}
