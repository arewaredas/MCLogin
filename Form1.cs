using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Launcher;
using CmlLib.Utils;
using CmlLib;
using System.IO;

namespace MC_Login
{
    public partial class Form1 : Form
    {
        public Form1(string file)
        {
            InitializeComponent();

            System.IO.TextReader fileread = System.IO.File.OpenText(file);
            username.Text = fileread.ReadToEnd();
            button1.PerformClick();
            fileread.Close();
        }
        void Hesabim()
        {
            basarimkazanildi.Text = "Başarım Kazanıldı";
            basarimadi.Text = "Hesabım";
            basarimaciklamasi.Text = "Bir hesap oluşturun.";

            File.Create(@"AchievementsData\Hesabim.mcloginachievement");

            basarimgidiyor.Start();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private Class1.EventHandlers handlers;
        private Class1.RichPresence presence;
        public static string user;
        public static string hesap;
        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Minecraft Username")
            {
                username.ForeColor = Color.Black;
                username.Text = "";
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.ForeColor = Color.Gray;
                username.Text = "Minecraft Username";
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = username.Text;
            if (username.Text == "" || username.Text == " " || username.Text == "  " || username.Text == "   " || username.Text == "    " || username.Text == "     " || username.Text == "      " || username.Text == "       " || username.Text == "        " || username.Text == "         " || username.Text == "          " || username.Text == "           " || username.Text == "            " || username.Text == "             " || username.Text == "              " || username.Text == "               " || username.Text == "                " || username.Text == "Minecraft Username")
            {
                username.ForeColor = Color.Gray;
                MessageBox.Show("Kullanıcı adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.speddyaredas.cf");
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                Application.Restart();
            }
        }

        public static void kullaniciadinioku()
        {
            string dosya_yolu = @"hesap\username.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
                hesap = yazi;
                sw.Close();
                fs.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.handlers = default(Class1.EventHandlers);
            Class1.Initialize("814431076712710174", ref this.handlers, true, null);
            this.handlers = default(Class1.EventHandlers);
            Class1.Initialize("814431076712710174", ref this.handlers, true, null);
            this.presence.details = "Giriş Yapıyor";
            this.presence.state = "";
            this.presence.largeImageKey = "mclogin";
            this.presence.smallImageKey = "None";
            this.presence.largeImageText = "MCLogin";
            Class1.UpdatePresence(ref this.presence);


            

            if (Directory.Exists("hesap"))
            {
                kullaniciadinioku();
                radioButton1.Text = hesap;
                radioButton1.ForeColor = Color.Black;

                pictureBox1.ImageLocation = "https://cravatar.eu/helmavatar/" + radioButton1.Text + "/190.png";
            }
            else
            {

            }

            if (Directory.Exists("hesap"))
            {
                if (Directory.Exists("AchievementsData"))
                {
                    if (File.Exists(@"AchievementsData\Hesabim.mcloginachievement"))
                    {

                    }
                    else
                    {
                        Form2.basarim = "Hesabim";

                        BasarimKazanildi kazan = new BasarimKazanildi();
                        kazan.Show();
                    }
                }
                else
                {
                    Directory.CreateDirectory("AchievementsData");
                    Form2.basarim = "Hesabim";

                    BasarimKazanildi kazan = new BasarimKazanildi();
                    kazan.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "MLG Dosyası Aç";
            opf.Filter = "MCLogin Profil Dosyası|*.mlg";
            opf.DefaultExt = "mlg";
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                username.Text = File.ReadAllText(opf.FileName, Encoding.Default);
                button1.PerformClick();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (Directory.Exists("hesap"))
                {
                    button3.Visible = true;
                }
                else
                {
                    OturumAç oturumac = new OturumAç();
                    oturumac.Show();
                    this.Hide();
                }
            }
            else
            {
                if (Directory.Exists("hesap"))
                {
                    button3.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user = radioButton1.Text;
            username.Text = radioButton1.Text;
            button1.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GuncellemeleriDenetle denetle = new GuncellemeleriDenetle();
            denetle.Show();
        }

        private void basarimgidiyor_Tick(object sender, EventArgs e)
        {
            basarimkazanildi.Text = "";
            basarimadi.Text = "";
            basarimaciklamasi.Text = "";

            basarimgidiyor.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Application.Restart();
            }
        }
    }
}
