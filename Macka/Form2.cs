using System;
using System.Windows.Forms;

namespace Macka
{
    public partial class Glavni : Form
    {
        public Glavni()
        {
            InitializeComponent();
            imeText.Text = "Osoba"; //ukoliko ne unesemo ime, bice osoba

            this.FormClosing += new FormClosingEventHandler(ZatvoriFormu);
        }

        private void DugmeStart_Click(object sender, EventArgs e) //dugme za pokretanje igre
        {
            string imeIgraca = imeText.Text; //ime igraca potrebno za formu 3 i formu 1
            this.Hide(); //sakrivamo ovu formu da bi prikazali drugu
            var igrica = new Igrica();
            igrica.ImeIgraca = imeIgraca;
            igrica.Closed += (s, args) => this.Close();
            igrica.Show(); //pocinje igra
        }

        private void DugmeRez_Click(object sender, EventArgs e)
        {
            this.Hide(); //prikazuje rezultate, prebacuje sa ove forme na formu 3
            Rezultati najveciRez = new Rezultati();
            najveciRez.ShowDialog();
        }

        private void Ulaz(object sender, EventArgs e)
        {
            if (imeText.Text == "Osoba")
            {
                imeText.Text = ""; //da bi mogli da unesemo svoje
            }
        }

        private void Izlaz(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imeText.Text))
            {
                imeText.Text = "Osoba"; //ako nista ne unesemo ostace osoba
            }
        }

        private void DugmePravila(object sender, EventArgs e)
        {
            this.Hide(); //da se prebacimo sa ove forme na formu za pravila
            var gameForm = new PravilaIgre();
            gameForm.Show();
        }

        private void ZatvoriFormu(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
