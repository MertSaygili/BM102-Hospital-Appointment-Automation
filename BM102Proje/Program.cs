using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
namespace BM102Proje
{
    static class Program
    {
        public static ChromiumWebBrowser chromeBrowser;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);                   // Browser ayarları yapılıyor.
            chromeBrowser = new ChromiumWebBrowser();
            Application.Run(new GirişPaneli());

        }
    }
}
