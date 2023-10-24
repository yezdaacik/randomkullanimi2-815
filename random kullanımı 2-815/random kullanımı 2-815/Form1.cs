using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_kullanımı_2_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            lbNotlar.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                int puan = rnd.Next(0, 100);
                lbNotlar.Items.Add(puan);
            }
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            int kaldi = 0, duz = 0, tesekkur = 0, takdir = 0;
            for (int i=0; i<lbNotlar.Items.Count; i++)
            {
                int puan = Convert.ToInt32(lbNotlar.Items[i]);
                if (puan<50)
                {
                    kaldi++;
                }
                else if (puan >= 50 && puan < 75)
                {
                    duz++;
                }
                else if (puan >= 75 && puan <90)
                {
                    tesekkur++;
                }
                else
                {
                    takdir++;
                }   
                lblKalan.Text=" Kalan öğrenci sayısı: "+ Convert.ToString(kaldi);
                lblGecen.Text ="Düz geçen öğrenci sayısı: "+ Convert.ToString(duz);
                lblTakdir.Text="Takdir sayısı: "+ Convert.ToString(takdir);
                lblTesekkur.Text="Teşekkür sayısı: "+ Convert.ToString(tesekkur);
            }
        }
    }
}
