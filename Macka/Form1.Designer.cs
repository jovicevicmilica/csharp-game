namespace Macka
{
    partial class Igrica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Igrica));
            this.TajmerIgre = new System.Windows.Forms.Timer(this.components);
            this.Rezultat = new System.Windows.Forms.Label();
            this.DugmePovratak = new System.Windows.Forms.Button();
            this.TajmerPovecavanja = new System.Windows.Forms.Timer(this.components);
            this.TajmerProvidnosti = new System.Windows.Forms.Timer(this.components);
            this.TajmerImuniteta = new System.Windows.Forms.Timer(this.components);
            this.Pravougaonik = new System.Windows.Forms.Panel();
            this.TajmerPravougaonika = new System.Windows.Forms.Timer(this.components);
            this.TajmerNagrade = new System.Windows.Forms.Timer(this.components);
            this.Nagrada = new System.Windows.Forms.PictureBox();
            this.punoSrce3 = new System.Windows.Forms.PictureBox();
            this.punoSrce2 = new System.Windows.Forms.PictureBox();
            this.punoSrce1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Konzerva = new System.Windows.Forms.PictureBox();
            this.Ograda = new System.Windows.Forms.PictureBox();
            this.Macka = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TajmerDupliranja = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Nagrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punoSrce3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punoSrce2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punoSrce1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Konzerva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ograda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Macka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TajmerIgre
            // 
            this.TajmerIgre.Interval = 20;
            this.TajmerIgre.Tick += new System.EventHandler(this.IgraTajmer);
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSize = true;
            this.Rezultat.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rezultat.Location = new System.Drawing.Point(16, 25);
            this.Rezultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(124, 20);
            this.Rezultat.TabIndex = 4;
            this.Rezultat.Text = "Rezultat: 0";
            // 
            // DugmePovratak
            // 
            this.DugmePovratak.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DugmePovratak.Location = new System.Drawing.Point(16, 60);
            this.DugmePovratak.Margin = new System.Windows.Forms.Padding(4);
            this.DugmePovratak.Name = "DugmePovratak";
            this.DugmePovratak.Size = new System.Drawing.Size(135, 28);
            this.DugmePovratak.TabIndex = 5;
            this.DugmePovratak.Text = "Povratak";
            this.DugmePovratak.UseVisualStyleBackColor = true;
            this.DugmePovratak.Click += new System.EventHandler(this.DugmePovratak_Click);
            // 
            // TajmerPovecavanja
            // 
            this.TajmerPovecavanja.Interval = 10000;
            // 
            // TajmerProvidnosti
            // 
            this.TajmerProvidnosti.Interval = 200;
            // 
            // TajmerImuniteta
            // 
            this.TajmerImuniteta.Interval = 3000;
            // 
            // Pravougaonik
            // 
            this.Pravougaonik.BackColor = System.Drawing.Color.LimeGreen;
            this.Pravougaonik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pravougaonik.Location = new System.Drawing.Point(284, 25);
            this.Pravougaonik.Margin = new System.Windows.Forms.Padding(4);
            this.Pravougaonik.Name = "Pravougaonik";
            this.Pravougaonik.Size = new System.Drawing.Size(159, 24);
            this.Pravougaonik.TabIndex = 10;
            this.Pravougaonik.Visible = false;
            // 
            // TajmerPravougaonika
            // 
            this.TajmerPravougaonika.Interval = 1000;
            // 
            // TajmerNagrade
            // 
            this.TajmerNagrade.Interval = 9000;
            // 
            // Nagrada
            // 
            this.Nagrada.Image = global::Macka.Properties.Resources.riba1;
            this.Nagrada.Location = new System.Drawing.Point(680, 155);
            this.Nagrada.Margin = new System.Windows.Forms.Padding(4);
            this.Nagrada.Name = "Nagrada";
            this.Nagrada.Size = new System.Drawing.Size(45, 35);
            this.Nagrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Nagrada.TabIndex = 9;
            this.Nagrada.TabStop = false;
            this.Nagrada.Tag = "nagrada";
            // 
            // punoSrce3
            // 
            this.punoSrce3.Image = global::Macka.Properties.Resources.puno;
            this.punoSrce3.Location = new System.Drawing.Point(671, 15);
            this.punoSrce3.Margin = new System.Windows.Forms.Padding(4);
            this.punoSrce3.Name = "punoSrce3";
            this.punoSrce3.Size = new System.Drawing.Size(35, 30);
            this.punoSrce3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.punoSrce3.TabIndex = 8;
            this.punoSrce3.TabStop = false;
            // 
            // punoSrce2
            // 
            this.punoSrce2.Image = global::Macka.Properties.Resources.puno;
            this.punoSrce2.Location = new System.Drawing.Point(616, 15);
            this.punoSrce2.Margin = new System.Windows.Forms.Padding(4);
            this.punoSrce2.Name = "punoSrce2";
            this.punoSrce2.Size = new System.Drawing.Size(35, 30);
            this.punoSrce2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.punoSrce2.TabIndex = 8;
            this.punoSrce2.TabStop = false;
            // 
            // punoSrce1
            // 
            this.punoSrce1.Image = global::Macka.Properties.Resources.puno;
            this.punoSrce1.Location = new System.Drawing.Point(561, 15);
            this.punoSrce1.Margin = new System.Windows.Forms.Padding(4);
            this.punoSrce1.Name = "punoSrce1";
            this.punoSrce1.Size = new System.Drawing.Size(35, 30);
            this.punoSrce1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.punoSrce1.TabIndex = 8;
            this.punoSrce1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Macka.Properties.Resources.vecioblak;
            this.pictureBox6.Location = new System.Drawing.Point(593, 71);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(120, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Macka.Properties.Resources.oblak1;
            this.pictureBox5.Location = new System.Drawing.Point(371, 96);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Macka.Properties.Resources.oblak1;
            this.pictureBox2.Location = new System.Drawing.Point(197, 71);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Konzerva
            // 
            this.Konzerva.BackColor = System.Drawing.Color.Transparent;
            this.Konzerva.Image = global::Macka.Properties.Resources.konzerva1;
            this.Konzerva.Location = new System.Drawing.Point(417, 286);
            this.Konzerva.Margin = new System.Windows.Forms.Padding(4);
            this.Konzerva.Name = "Konzerva";
            this.Konzerva.Size = new System.Drawing.Size(40, 43);
            this.Konzerva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Konzerva.TabIndex = 3;
            this.Konzerva.TabStop = false;
            this.Konzerva.Tag = "prepreka";
            // 
            // Ograda
            // 
            this.Ograda.BackColor = System.Drawing.Color.Transparent;
            this.Ograda.Image = global::Macka.Properties.Resources.ograda1;
            this.Ograda.Location = new System.Drawing.Point(640, 265);
            this.Ograda.Margin = new System.Windows.Forms.Padding(4);
            this.Ograda.Name = "Ograda";
            this.Ograda.Size = new System.Drawing.Size(70, 60);
            this.Ograda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ograda.TabIndex = 2;
            this.Ograda.TabStop = false;
            this.Ograda.Tag = "prepreka";
            // 
            // Macka
            // 
            this.Macka.BackColor = System.Drawing.Color.Transparent;
            this.Macka.Image = global::Macka.Properties.Resources.trci;
            this.Macka.Location = new System.Drawing.Point(73, 252);
            this.Macka.Margin = new System.Windows.Forms.Padding(4);
            this.Macka.Name = "Macka";
            this.Macka.Size = new System.Drawing.Size(121, 86);
            this.Macka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Macka.TabIndex = 1;
            this.Macka.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Macka.Properties.Resources.r3;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 293);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1147, 239);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Macka.Properties.Resources.vecioblak;
            this.pictureBox7.Location = new System.Drawing.Point(-24, 71);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(120, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(733, 385);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // TajmerDupliranja
            // 
            this.TajmerDupliranja.Interval = 5000;
            // 
            // Igrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(731, 385);
            this.Controls.Add(this.Pravougaonik);
            this.Controls.Add(this.Nagrada);
            this.Controls.Add(this.punoSrce3);
            this.Controls.Add(this.punoSrce2);
            this.Controls.Add(this.punoSrce1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DugmePovratak);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.Konzerva);
            this.Controls.Add(this.Ograda);
            this.Controls.Add(this.Macka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Igrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Igrica";
            this.TransparencyKey = System.Drawing.Color.Peru;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dolje);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Gore);
            ((System.ComponentModel.ISupportInitialize)(this.Nagrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punoSrce3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punoSrce2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punoSrce1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Konzerva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ograda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Macka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Macka;
        private System.Windows.Forms.PictureBox Ograda;
        private System.Windows.Forms.PictureBox Konzerva;
        private System.Windows.Forms.Timer TajmerIgre;
        private System.Windows.Forms.Label Rezultat;
        private System.Windows.Forms.Button DugmePovratak;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer TajmerPovecavanja;
        private System.Windows.Forms.PictureBox punoSrce1;
        private System.Windows.Forms.PictureBox punoSrce2;
        private System.Windows.Forms.PictureBox punoSrce3;
        private System.Windows.Forms.Timer TajmerProvidnosti;
        private System.Windows.Forms.Timer TajmerImuniteta;
        private System.Windows.Forms.Panel Pravougaonik;
        private System.Windows.Forms.Timer TajmerPravougaonika;
        private System.Windows.Forms.Timer TajmerNagrade;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Nagrada;
        private System.Windows.Forms.Timer TajmerDupliranja;
    }
}

