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
        Dizi duzenlenen;
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
            if (duzenlenen == null)
            {
                db.Diziler.Add(new Dizi()
                {
                    Ad = diziAd,
                    Sezon = (int)nudSezon.Value,
                    Bolum = (int)nudBolum.Value,
                    BittiMi = chkBittiMi.Checked
                });
            }
            else
            {
                duzenlenen.Ad = diziAd;
                
            }


            db.SaveChanges();
            FormuResetle();
            Listele();

        }

        private void FormuResetle()
        {
            duzenlenen = null;
            txtAd.Clear();
            nudSezon.Value = nudBolum.Value = 0;
            chkBittiMi.Checked = false;
            btnEkle.Text = "Ekle";
            btnIptal.Hide();
            txtAd.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvDiziler.SelectedRows.Count != 1) return;

            Dizi dizi = (Dizi)dgvDiziler.SelectedRows[0].DataBoundItem;
            db.Diziler.Remove(dizi);
            db.SaveChanges();
            Listele();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvDiziler.SelectedRows.Count != 1) return;

            Dizi dizi = (Dizi)dgvDiziler.SelectedRows[0].DataBoundItem;
            txtAd.Text = dizi.Ad;
            nudSezon.Value = dizi.Sezon;
            nudBolum.Value = dizi.Bolum;
            chkBittiMi.Checked = dizi.BittiMi;
            btnEkle.Text = "Kaydet";
            btnIptal.Show();

        }
    }
}
