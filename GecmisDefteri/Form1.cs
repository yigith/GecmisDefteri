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
    public partial class Form1 : Form
    {
        private List<Mesaj> _mesajlar;
        private BindingList<Mesaj> _blMesajlar;

        public Form1()
        {
            VerileriOku();
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            lstMesajlar.DataSource = _blMesajlar;
        }

        private void VerileriOku()
        {
            _mesajlar = new List<Mesaj>();
            _blMesajlar = new BindingList<Mesaj>(_mesajlar); // _blMesajlar'a veri eklendiğinde otomatik olarak _mesajlar'a da eklenecek
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var icerik = txtMesaj.Text;

            if (icerik == "")
            {
                MessageBox.Show("Lütfen bir mesaj giriniz.");
                return;
            }

            _mesajlar.Add(new Mesaj(icerik));
            _mesajlar.Sort();
            _blMesajlar.ResetBindings(); // binding list üzerindeki değişiklikleri veri kaynağı olduğu kontrollere (lstMesajlar) haber ver
            txtMesaj.Clear();
        }

        private void txtMesaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // tuşa basılmamış gibi davran (windows ding sesini de önlüyor)
                btnEkle.PerformClick(); // btnEkle butonuna tıkla
            }
        }
    }
}
