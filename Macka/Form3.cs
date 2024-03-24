using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Macka
{
    public partial class Rezultati : Form
    {
        public Rezultati()
        {
            InitializeComponent();

            List<Rezultat> najveciRez = menadzerRez.ucitajRezultate(); //ucitamo rezultate iz igre
            lista.DataSource = najveciRez; 
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Rezultat> najveciRez = menadzerRez.ucitajRezultate();
            lista.DataSource = null;
            lista.DataSource = najveciRez;
        }

        private void DugmePovratak_Click(object sender, EventArgs e) //dugme za povratak na glavni ekran
        {
            this.Hide();
            var MeniForma = new Glavni();
            MeniForma.Closed += (s, args) => this.Close();
            MeniForma.Show();
        }
    }

    public static class menadzerRez //klasa za upisivanje u rezultate, i ucitavanje rezultata
    {
        private static string put = "rezultati.txt";

        public static List<Rezultat> ucitajRezultate()
        {
            var najveciRezultati = new List<Rezultat>(); //napravimo listu

            if (File.Exists(put)) //ako postoji fajl, upisujemo
            {
                string[] rezultati = File.ReadAllLines(put); //procitamo sve iz fajla

                foreach (var line in rezultati)
                {
                    var parts = line.Split('-'); //podijelimo po crtici, lijevo je ime igraca a desno rezultat
                    if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int postignutiRez))
                    {
                        najveciRezultati.Add(new Rezultat { ImeIgraca = parts[0].Trim(), PostignutiRez = postignutiRez });
                        //dodamo novo
                    }
                }
            }

            return najveciRezultati;
        }

        public static void sacuvajRezultat(Rezultat rezultat) //da na trenutne rezultate dopisemo novi
        {
            var najveciRezultati = ucitajRezultate(); //ucitamo ga

            najveciRezultati.Add(rezultat);
            najveciRezultati = najveciRezultati.OrderByDescending(r => r.PostignutiRez).Take(10).ToList();
            //poredjamo ih od najveceg do najmanjeg, uzima se top 10

            File.WriteAllLines(put, najveciRezultati.Select(r => $"{r.ImeIgraca} - {r.PostignutiRez}").ToArray());
            //upise se u formi igrac - rezultat
        }
    }

    public class Rezultat //nacin na koji se rezultat pamti u fajlu
    {
        public string ImeIgraca { get; set; } 
        public int PostignutiRez { get; set; }

        public override string ToString()
        {
            return $"{ImeIgraca} - {PostignutiRez}"; //nacin upisivanja rezultata
        }
    }
}