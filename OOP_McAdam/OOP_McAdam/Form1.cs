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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 68;
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text==_childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum==false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new MenuOlustur());
        }

        private void siparisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SiparisOlustur()); //icerde ilgili chil formun instance'i alindi.
        }

        private void ekstraOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new EkstraOlustur());
        }

        private void siparislerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Siparisler());
        }
    }
}
