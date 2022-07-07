using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_McAdam
{
    public partial class MenuOlustur : Form
    {
        public MenuOlustur()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            if (txtMenuAdi.Text != "" && nudMenuFiyat.Value != 0)
            {
                Burger burger = new Burger();
                burger.UrunAdi = txtMenuAdi.Text;
                burger.Fiyat = nudMenuFiyat.Value;
                Burger.burgerListesi.Add(burger);
            }
            else
            {
                MessageBox.Show("Urun secimi veya fiyat bilgisi eksik!");
            }

            nudMenuFiyat.Value = 0;
            txtMenuAdi.Text = "";
        }
    }
}
