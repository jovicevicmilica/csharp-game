namespace Macka
{
    partial class Glavni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavni));
            this.DugmeStart = new System.Windows.Forms.Button();
            this.DugmeRez = new System.Windows.Forms.Button();
            this.DugmeIzadji = new System.Windows.Forms.Button();
            this.imeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DugmeStart
            // 
            this.DugmeStart.Font = new System.Drawing.Font("Minecraft", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DugmeStart.Location = new System.Drawing.Point(190, 74);
            this.DugmeStart.Name = "DugmeStart";
            this.DugmeStart.Size = new System.Drawing.Size(150, 47);
            this.DugmeStart.TabIndex = 0;
            this.DugmeStart.Text = "Pocni igru";
            this.DugmeStart.UseVisualStyleBackColor = true;
            this.DugmeStart.Click += new System.EventHandler(this.DugmeStart_Click);
            // 
            // DugmeRez
            // 
            this.DugmeRez.Font = new System.Drawing.Font("Minecraft", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DugmeRez.Location = new System.Drawing.Point(190, 143);
            this.DugmeRez.Name = "DugmeRez";
            this.DugmeRez.Size = new System.Drawing.Size(150, 47);
            this.DugmeRez.TabIndex = 1;
            this.DugmeRez.Text = "Najveci rezultati";
            this.DugmeRez.UseVisualStyleBackColor = true;
            this.DugmeRez.Click += new System.EventHandler(this.DugmeRez_Click);
            // 
            // DugmeIzadji
            // 
            this.DugmeIzadji.Font = new System.Drawing.Font("Minecraft", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DugmeIzadji.Location = new System.Drawing.Point(190, 213);
            this.DugmeIzadji.Name = "DugmeIzadji";
            this.DugmeIzadji.Size = new System.Drawing.Size(150, 47);
            this.DugmeIzadji.TabIndex = 2;
            this.DugmeIzadji.Text = "Pravila";
            this.DugmeIzadji.UseVisualStyleBackColor = true;
            this.DugmeIzadji.Click += new System.EventHandler(this.DugmePravila);
            // 
            // imeText
            // 
            this.imeText.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeText.Location = new System.Drawing.Point(12, 39);
            this.imeText.Name = "imeText";
            this.imeText.Size = new System.Drawing.Size(100, 24);
            this.imeText.TabIndex = 6;
            this.imeText.Text = "Osoba";
            this.imeText.Enter += new System.EventHandler(this.Ulaz);
            this.imeText.Leave += new System.EventHandler(this.Izlaz);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unesite ime:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Macka.Properties.Resources.oblak1;
            this.pictureBox7.Location = new System.Drawing.Point(386, 39);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(91, 52);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Macka.Properties.Resources.oblak1;
            this.pictureBox3.Location = new System.Drawing.Point(27, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Macka.Properties.Resources.vecioblak;
            this.pictureBox8.Location = new System.Drawing.Point(315, 228);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(188, 94);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Macka.Properties.Resources.oblak1;
            this.pictureBox5.Location = new System.Drawing.Point(116, 186);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(91, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Macka.Properties.Resources.vecioblak;
            this.pictureBox6.Location = new System.Drawing.Point(157, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(171, 105);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Macka.Properties.Resources.frame_01_delay_0_1s;
            this.pictureBox1.Location = new System.Drawing.Point(-85, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Glavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(550, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imeText);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.DugmeIzadji);
            this.Controls.Add(this.DugmeRez);
            this.Controls.Add(this.DugmeStart);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Glavni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni Ekran";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DugmeStart;
        private System.Windows.Forms.Button DugmeRez;
        private System.Windows.Forms.Button DugmeIzadji;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox imeText;
        private System.Windows.Forms.Label label1;
    }
}