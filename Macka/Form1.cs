using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Macka
{
    public partial class Igrica : Form
    {
        Random rand = new Random();

        //PARAMETRI ZA IGRU
        bool skace = false; //da li macka skace, aktivirano kada se klikne space
        int brzinaSkoka;
        double jacina = 13;
        int rezultat = 0; 
        int brzinaPrepreke = 12; 
        int pozicija;
        bool jeKraj = false; //da li je kraj igre
        public string ImeIgraca { get; set; } //potrebno za formu 2 i 3 gdje biljezimo najvece rezultate
        bool jePauzirano = false;
        int povecanjeBrzine = 1;  //parametar potreban za ubrzavanje svakih 10 sekundi
        int maksimalanBrojSkokova = 2; //ograniceno na double jump
        int brojSkokova = 0; //trenutan broj skokova
        int brojZivota = 3; 
        bool udarena = false; //da li je macka udarena, da bi se makao zivot
        int brojBlicanja = 0; //za "trepet" efekat prilikom udaranja u prepreku
        bool imaImunitet = false; //kada pojede ribu, dobije imunitet 3 sek
        int vrijemeSmanjenja = 0; //za tajmer pravougaonika
        bool zvjezdicaAktivna = false; //dok je aktivna, rezultat se duplira 5 sekundi
        bool jePokupljenaRiba = false;
        bool jePokupljenaZvjezdica = false;
        SoundPlayer muzika = new SoundPlayer("C:\\Users\\User\\Desktop\\resized\\pjesma.wav");
        SoundPlayer kraj = new SoundPlayer("C:\\Users\\User\\Desktop\\resized\\krajigre.wav");

        public Igrica()
        {
            InitializeComponent();

            ResetujIgru(); //pocetno stanje igre

            //TAJMERI   
            DugmePovratak.TabStop = false; //da se ne bi na klik "space" vratilo nazad 

            TajmerPovecavanja.Tick += PovecajBrzinu; //tajmer za ubrzavanje igre na 10 sekundi
            TajmerPovecavanja.Start(); //pocinje odmah pri pocetku igre da odbrojava

            TajmerProvidnosti.Tick += Blicaj; //tajmer "treperenja" prilikom udara u prepreku

            TajmerImuniteta.Tick += ImajImunitet; //tajmer od 3 sekunde imuniteta nakon sto se pokupi riba

            TajmerDupliranja.Tick += DuplirajRezultat; //tajmer od 5 sekundi dupliranja rezultata nakon sto se pokupi riba

            TajmerPravougaonika.Tick += SmanjiPravougaonik; //tajmer za nagrade, pojavi se pravougaonik

            Nagrada.Visible = false; //na pocetku je nema, javlja se na svakih 9 - 20 sekundi
            TajmerNagrade.Interval = rand.Next(5000, 15000); //pojavljuje se na svakih 5 - 15 sekundi
            TajmerNagrade.Tick += NagradaAkt; //tajmer za nagrade
            TajmerNagrade.Start();

            muzika.PlayLooping(); //pozadinska muzika

            this.FormClosing += new FormClosingEventHandler(ZatvoriFormu);
            //event za gasenje forme na X
        }

        private void Dolje(object sender, KeyEventArgs e) //funkcija za kliknutu dugmad
        {
            if (e.KeyCode == Keys.Space && (!skace || brojSkokova < maksimalanBrojSkokova))
            {
                //ako smo kliknuli space i macka vec ne skace, a broj skokova je manji od 2, ona skoci
                skace = true;
                brojSkokova++;

                if (brojSkokova == 1)
                {
                    brzinaSkoka = -12;
                }

                else if (brojSkokova == 2) //da bi dupli skok imao vecu gravitaciju
                {
                    brzinaSkoka = -15;
                }
            }

            if (e.KeyCode == Keys.P) //da pauziramo igru
            {
                if (!jeKraj)
                {
                    jePauzirano = !jePauzirano;
                }

                if (jePauzirano) //ako smo pauzirali
                {
                    TajmerIgre.Stop();
                    TajmerImuniteta.Stop();
                    TajmerDupliranja.Stop();
                    TajmerPravougaonika.Stop();
                    Pravougaonik.Visible = false;
                    Rezultat.Text = "Igra je pauzirana. Pritisnite P da nastavite.";
                    Macka.Image = Properties.Resources.stoji;

                }

                else //kada odpauziramo
                {
                    TajmerIgre.Start();
                    Macka.Image = Properties.Resources.trci;
                }
            }
        }

        private void Gore(object sender, KeyEventArgs e) //funkcija za otpustanje dugmadi
        {
            if (skace) //ako skace, prestaje da skace
            {
                skace = false;
            }

            if (e.KeyCode == Keys.R && jeKraj) //resetujemo igru na kraju, krecemo od pocetnog stanja
            {
                ResetujIgru();
            }
        }

        private void IgraTajmer(object sender, EventArgs e) //glavni tajmer igre
        {
            Macka.Top += brzinaSkoka; //za koliko se macka podize tokom skoka
            Rezultat.Text = "Rezultat: " + rezultat;

            if (skace && jacina < 0) //prestao skok
            {
                skace = false;
            }

            if (skace)
            {
                brzinaSkoka = -12;
                jacina -= 0.8;
            }

            else
            {
                brzinaSkoka = 12;
            }

            if (Macka.Top > 198 && skace == false) //vrace se na dno nakon skokova
            {
                Macka.Top = 199;
                jacina = 13;
                brzinaSkoka = 0;
                brojSkokova = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "prepreka")
                {
                    x.Left -= brzinaPrepreke; //da bi se prepreke pomjerale

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 1000) + (x.Width * 15);

                        do
                        {
                            x.Left = this.ClientSize.Width + rand.Next(200, 1000) + (x.Width * 15);
                        }
                        while (this.Controls.Cast<Control>().Any(other => other != x && other is PictureBox && preklapajuSe(x, other)));
                        //da se prepreke ne bi sudarale medjusobno i sa nagradama


                        if (zvjezdicaAktivna) //ukoliko je aktivan ovaj powerup, onda se rezultat uvecava duplo
                        {
                            rezultat += 2;
                        }

                        else //inace za 1
                        {
                            rezultat++;
                        }

                        udarena = false; //potrebno za micanje zivota
                    }

                    if (Macka.Bounds.IntersectsWith(x.Bounds) && !udarena) //ako macka udari u prepreku, a nije vec udarena
                    {
                        if (imaImunitet) continue; //ukoliko je pokupila ribu

                        IzgubiZivot(); //inace gubi zivot
                        udarena = true;
                    }
                }

                if (x is PictureBox && ((string)x.Tag == "riba" || (string)x.Tag == "zvjezdica") && x.Visible == true) //ukoliko smo naisli na vidljivu nagradu, posto su one na pocetku sakrivene
                {
                    x.Left -= brzinaPrepreke; //nagrada se krece brzinom prepreke

                    if (x.Left < -100)
                    {
                        x.Visible = false; //nestaje
                    }

                    if (Macka.Bounds.IntersectsWith(x.Bounds) && (string)x.Tag == "riba")
                    {
                        imaImunitet = true; //dobija imunitet 3s
                        x.Visible = false; //pokupimo nagradu i vise je nema

                        TajmerImuniteta.Start(); //tajmer od 3s tokom kojeg smije da udari u prepreku

                        vrijemeSmanjenja = 0; //potrebno za podesavanje pravougaonika u posebnom tajmeru
                        Pravougaonik.Width = 120;
                        Pravougaonik.Visible = true; //pojavi se pravougaonik
                        TajmerPravougaonika.Start(); //pocne tajmer
                        jePokupljenaRiba = true;
                    }

                    else if (Macka.Bounds.IntersectsWith(x.Bounds) && (string)x.Tag == "zvjezdica")
                    {
                        zvjezdicaAktivna = true; //da bi znali da se tokom perioda aktivnosti rezultat uvecava duplo
                        x.Visible = false; //pokupimo nagradu i vise je nema

                        TajmerDupliranja.Start();

                        vrijemeSmanjenja = 0;
                        Pravougaonik.Width = 120;
                        Pravougaonik.Visible = true;
                        TajmerPravougaonika.Start();
                        jePokupljenaZvjezdica = true;
                    }
                }
            }
        }
        private void ResetujIgru()
        {
            //PARAMETRI RESETOVANJA
            jacina = 13;
            brzinaSkoka = 0;
            skace = false;
            rezultat = 0;
            brzinaPrepreke = 12;
            Rezultat.Text = "Rezultat: " + rezultat;
            Macka.Image = Properties.Resources.trci;
            jeKraj = false;
            Macka.Top = 199; //vratimo macku na pocetnu poziciju
            brojZivota = 3; //vratimo zivote
            kraj.Stop(); //zaustavimo muziku za kraj
            muzika.PlayLooping(); //pocne nova muzika
            jePokupljenaRiba = false;
            jePokupljenaZvjezdica = false;
            zvjezdicaAktivna = false; //vratimo parametre nagrada na 0
            udarena = false; //macka nije udarena na pocetku
            Nagrada.Visible = false;

            TajmerNagrade.Stop();
            TajmerNagrade.Start();

            punoSrce1.Image = Properties.Resources.puno;
            punoSrce2.Image = Properties.Resources.puno;
            punoSrce3.Image = Properties.Resources.puno; //napunimo prazna srca

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "prepreka") //postavimo prepreke
                {
                    pozicija = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = pozicija;
                }
            }

            TajmerIgre.Start(); //pocne igra i novi tajmer
        }

        private void DugmePovratak_Click(object sender, EventArgs e) //dugme koje nas vodi na formu 2, odnosno na glavni meni
        {
            //ZAUSTAVLJANJE TAJMERA
            TajmerIgre.Stop();
            TajmerPravougaonika.Stop();
            TajmerImuniteta.Stop();
            TajmerNagrade.Stop();
            TajmerProvidnosti.Stop();

            jeKraj = true;

            muzika.Stop();
            kraj.Stop();
            Pravougaonik.Visible = false; //da se makne pravougaonik ako se desi da je prisutan kad se zavrsi igra

            this.Hide(); //sakrijemo ovu formu
            var MeniForma = new Glavni(); //prebacimo na formu 2
            MeniForma.Closed += (s, args) => this.Close();
            MeniForma.Show(); //pokazemo novu formu
            muzika.Stop(); //zaustavimo muziku i sve
            kraj.Stop();
        }

        private void PovecajBrzinu(object sender, EventArgs e)
        {
            brzinaPrepreke += povecanjeBrzine; //uvecamo brzinu za 1 svakih 10 sekundi
        }

        private void IzgubiZivot() //funkcija za gubitak zivota
        {
            brojZivota--;  //smanjimo varijablu

            if (brojZivota >= 0) //podesavamo prazna srca
            {
                var srceSlika = this.Controls["punoSrce" + (brojZivota + 1)] as PictureBox;

                if (srceSlika != null)
                {
                    srceSlika.Image = Properties.Resources.prazno; //ispraznimo srce kad se izgubi zivot
                }

                brojBlicanja = 0;
                TajmerProvidnosti.Start(); //pocne tajmer treperenja kad udarimo u nesto
            }

            if (brojZivota == 0) //izgubili smo
            {
                //ZAUSTAVLJANJE TAJMERA
                TajmerIgre.Stop();
                TajmerPravougaonika.Stop();
                TajmerImuniteta.Stop();
                TajmerNagrade.Stop();
                TajmerProvidnosti.Stop();

                Macka.Image = Properties.Resources.kraj; //macka kada izgubi, prebacimo na nju
                Rezultat.Text += "   Kliknite R da pocnete ponovo!"; //tekst za kraj
                jeKraj = true;
                menadzerRez.sacuvajRezultat(new Rezultat { ImeIgraca = this.ImeIgraca, PostignutiRez = rezultat });
                //sacuvamo rezultat za formu 3 gdje ce se upisati

                Macka.Visible = true;
                muzika.Stop();
                kraj.Play(); //muzika za kraj
                Pravougaonik.Visible = false; //da se makne pravougaonik ako se desi da je prisutan kad se zavrsi igra
            }

            else
            {
                udarena = false; //inace nije udarena
            }
        }

        private void Blicaj(object sender, EventArgs e) //funkcija za efekat treperenja po udaranju u prepreku
        {
            if (brojBlicanja >= 4) //otprilike broj treperenja
            {
                TajmerProvidnosti.Stop();
                brojBlicanja = 0;
                Macka.Visible = true;
                return;
            }

            Macka.Visible = !Macka.Visible; //efekat treperenja

            brojBlicanja++;
        }

        private void NagradaAkt(object sender, EventArgs e) //funkcija za tajmer nagrade
        {
            TajmerNagrade.Interval = rand.Next(5000, 15000); //pojavljuje se na svakih 5 - 15 sekundi
            int x = rand.Next(1, 3); //1 ili 2, random pojava nagrade

            if (x == 1) //ukoliko je 1, prikazimo ribu kao nagradu
            {
                Nagrada.Image = Properties.Resources.riba1;
                Nagrada.Top = rand.Next(120, 250); //random pozicija nagrade
                Nagrada.Left = this.ClientSize.Width;
                Nagrada.Visible = true;
                Nagrada.Tag = "riba";
            }

            if (x == 2) //inace je nagrada zvjezdica
            {
                Nagrada.Image = Properties.Resources.zvjezdica3;
                Nagrada.Top = rand.Next(120, 250);
                Nagrada.Left = this.ClientSize.Width;
                Nagrada.Visible = true;
                Nagrada.Tag = "zvjezdica";
            }

            while (this.Controls.Cast<Control>().Any(other => other is PictureBox && other != Nagrada && (string)other.Tag == "prepreka" && preklapajuSe(Nagrada, other)))
            {
                Nagrada.Left = this.ClientSize.Width + rand.Next(200, 1000) + Nagrada.Width;
            }
            //da sprijecimo sudaranje
        }

        public void DuplirajRezultat(object sender, EventArgs e) //kada prodje dupliranje rezultata
        {
            zvjezdicaAktivna = false;
            TajmerDupliranja.Stop();
        }

        public void ImajImunitet(object sender, EventArgs e) //kada prodje imunitet
        {
            imaImunitet = false;
            TajmerImuniteta.Stop();
        }

        public void SmanjiPravougaonik(object sender, EventArgs e) //pravougaonik koji istice za nagrade
        {
            if (jePokupljenaRiba) //riba traje 3 sek, pa smanjujemo pravougaonik na 3 intervala
            {
                vrijemeSmanjenja++;

                if (vrijemeSmanjenja <= 3)
                {
                    Pravougaonik.Width = 120 - (vrijemeSmanjenja * 40);
                }
                else
                {
                    Pravougaonik.Visible = false; //kada prodje 3 sekunde, on nestaje
                    Pravougaonik.Width = 0;
                    jePokupljenaRiba = false;
                    vrijemeSmanjenja = 0;
                    TajmerPravougaonika.Stop(); //zavrsava se tajmer
                }
            }

            if (jePokupljenaZvjezdica) //zvjezdica traje 5 sek, pa smanjujemo pravougaonik na 5 intervala
            {
                vrijemeSmanjenja++;

                if (vrijemeSmanjenja <= 5)
                {
                    Pravougaonik.Width = 120 - (vrijemeSmanjenja * 24);
                }
                else
                {
                    Pravougaonik.Visible = false;
                    Pravougaonik.Width = 0;
                    jePokupljenaZvjezdica = false;
                    zvjezdicaAktivna = false;
                    vrijemeSmanjenja = 0;
                    TajmerPravougaonika.Stop();
                }
            }
        }

        private bool preklapajuSe(Control kontrola1, Control kontrola2) //da li se dvije kontrole preklapaju
        {
            return kontrola1.Bounds.IntersectsWith(kontrola2.Bounds);
        }

        private void ZatvoriFormu(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); //gasenje forme
        }
    }
}
