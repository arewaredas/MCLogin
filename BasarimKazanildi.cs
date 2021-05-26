using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MC_Login
{
    public partial class BasarimKazanildi : Form
    {
        public BasarimKazanildi()
        {
            InitializeComponent();
        }
        void IlkProfil()
        {
            pictureBox1.ImageLocation = @"BasarimResimleri\IlkProfil.png";
            basarimkazanildi0.Text = "Başarım Kazanıldı";
            basarimadi.Text = "İlk Profil";
            basarimaciklamasi.Text = "İlk kez bir profili görüntüleyin.";

            basarimgidiyor.Start();

            File.Create(@"AchievementsData\IlkProfil.mcloginachievement");
        }


        void IhtiyacimVardi()
        {
            pictureBox1.ImageLocation = @"BasarimResimleri\IhtiyacimVardi.png";
            basarimkazanildi0.Text = "Başarım Kazanıldı";
            basarimadi.Text = "İhtiyacım Vardı";
            basarimaciklamasi.Text = "Bir avatarı indirin.";

            basarimgidiyor.Start();

            File.Create(@"AchievementsData\IhtiyacimVardi.mcloginachievement");
        }

        void EkranimKare()
        {
            pictureBox1.ImageLocation = @"BasarimResimleri\EkranimKare.png";
            basarimkazanildi0.Text = "Başarım Kazanıldı";
            basarimadi.Text = "Ekranım Kare";
            basarimaciklamasi.Text = "Kare monitör moduna geçin.";

            basarimgidiyor.Start();

            File.Create(@"AchievementsData\EkranimKare.mcloginachievement");
        }

        void Hesabim()
        {
            pictureBox1.ImageLocation = @"BasarimResimleri\Hesabim.png";
            basarimkazanildi0.Text = "Başarım Kazanıldı";
            basarimadi.Text = "Hesabım";
            basarimaciklamasi.Text = "Bir hesap oluşturun.";

            File.Create(@"AchievementsData\Hesabim.mcloginachievement");

            basarimgidiyor.Start();
        }
        private void BasarimKazanildi_Load(object sender, EventArgs e)
        {
            if (Form2.basarim == "IlkProfil")
            {
                if (Directory.Exists("AchievementsData"))
                {
                    if (File.Exists(@"AchievementsData\IlkProfil.mcloginachievement"))
                    {

                    }
                    else
                    {
                        IlkProfil();
                    }
                }
                else
                {
                    Directory.CreateDirectory("AchievementsData");
                    IlkProfil();
                }
            }


            if (Form2.basarim == "IhtiyacimVardi")
            {
                if (Directory.Exists("AchievementsData"))
                {
                    if (File.Exists(@"AchievementsData\IhtiyacimVardi.mcloginachievement"))
                    {

                    }
                    else
                    {
                        IhtiyacimVardi();
                    }
                }
                else
                {
                    Directory.CreateDirectory("AchievementsData");
                    IhtiyacimVardi();
                }
            }

            if (Form2.basarim == "EkranimKare")
            {
                if (Directory.Exists("AchievementsData"))
                {
                    if (File.Exists(@"AchievementsData\EkranimKare.mcloginachievement"))
                    {

                    }
                    else
                    {
                        EkranimKare();
                    }
                }
                else
                {
                    Directory.CreateDirectory("AchievementsData");
                    EkranimKare();
                }
            }

            if (Form2.basarim == "Hesabim")
            {
                if (Directory.Exists("AchievementsData"))
                {
                    if (File.Exists(@"AchievementsData\Hesabim.mcloginachievement"))
                    {

                    }
                    else
                    {
                        Hesabim();
                    }
                }
                else
                {
                    Directory.CreateDirectory("AchievementsData");
                    Hesabim();
                }
            }
        }

        private void basarimgidiyor_Tick(object sender, EventArgs e)
        {
            basarimkazanildi0.Text = "";
            basarimadi.Text = "";
            basarimaciklamasi.Text = "";
            pictureBox1.ImageLocation = "";
            panel1.BackColor = SystemColors.Control;

            basarimgidiyor.Stop();

            this.Close();
        }
    }
}
