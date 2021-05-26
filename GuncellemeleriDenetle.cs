using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace MC_Login
{
    public partial class GuncellemeleriDenetle : Form
    {
        public GuncellemeleriDenetle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Updates");


            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://mcloginn.github.io/Updates/MCLogin.4.9.Setup.exe",
            @"Updates\MCLogin.4.9.Setup.exe");

            System.Diagnostics.Process.Start(@"Updates\MCLogin.4.9.Setup.exe");

            this.Hide();
            timer1.Start();
        }

        private void GuncellemeleriDenetle_Load(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.ToString() == "https://mcloginn.github.io/4.8/guncellemeyok.html")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void GuncellemeleriDenetle_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
