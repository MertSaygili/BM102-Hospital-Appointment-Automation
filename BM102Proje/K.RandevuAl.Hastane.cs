using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace BM102Proje
{
    public partial class Hastaneler : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public Hastaneler()
        {
            InitializeComponent();
            
        }
        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(RandevuAl.url.ToString());
            // Add it to the form and fill it to the form window.
            panel1.Controls.Add(chromeBrowser);
                var script = @"
                document.getElementsByClassName('widget-pane-toggle-button noprint')[0].click();
            ";
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.ExecuteScriptAsyncWhenPageLoaded(script);
            Cef.EnableHighDPISupport();
        }

        private void Hastaneler_Load(object sender, EventArgs e)
        {
            InitializeChromium();
        }

        private void Hastaneler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
