using DiziTakip_EntityCF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziTakip_EntityCF
{
    public partial class Form1 : Form
    {
        DiziTakipContext db = new DiziTakipContext();
        public Form1()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            dgvDiziler.DataSource = db.Diziler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string diziAd = txtAd.Text.Trim();
            if (diziAd == "") return;

            db.Diziler.Add(new Dizi()
            {
                Ad=diziAd,
                Sezon=(int)nudSezon.Value,
                Bolum=(int)nudBolum.Value,
                BittiMi=chkBittiMi.Checked
            });
            db.SaveChanges();
            Listele();
            
        }
    }
}
