using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GecmisDefteri
{
    public partial class DuzenleForm : Form
    {
        private readonly Mesaj _mesaj;

        public DuzenleForm(Mesaj mesaj)
        {
            InitializeComponent();
            txtMesaj.Text = mesaj.Icerik;
            dtpZaman.Value = mesaj.Zaman;
            chkFavori.Checked = mesaj.YildizliMi;
            _mesaj = mesaj;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string icerik = txtMesaj.Text.Trim();

            if (icerik == "")
            {
                MessageBox.Show("Lütfen bir mesaj giriniz.");
                return;
            }

            _mesaj.Icerik = icerik;
            _mesaj.Zaman = dtpZaman.Value;
            _mesaj.YildizliMi = chkFavori.Checked;
            Close();
        }
    }
}
