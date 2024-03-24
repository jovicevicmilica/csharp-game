using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macka
{
    public partial class PravilaIgre : Form
    {
        public PravilaIgre()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(ZatvoriFormu);
        }

        private void DugmePovratak_Click(object sender, EventArgs e) //povratak na glavni ekran
        {
            this.Hide();
            var MeniForma = new Glavni();
            MeniForma.Closed += (s, args) => this.Close();
            MeniForma.Show();
        }

        private void ZatvoriFormu(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
