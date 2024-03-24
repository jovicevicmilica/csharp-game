namespace Macka
{
    partial class Rezultati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezultati));
            this.lista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DugmePovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Cursor = System.Windows.Forms.Cursors.Default;
            this.lista.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 19;
            this.lista.Location = new System.Drawing.Point(172, 90);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(183, 194);
            this.lista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezultati";
            // 
            // DugmePovratak
            // 
            this.DugmePovratak.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DugmePovratak.Location = new System.Drawing.Point(12, 32);
            this.DugmePovratak.Name = "DugmePovratak";
            this.DugmePovratak.Size = new System.Drawing.Size(101, 23);
            this.DugmePovratak.TabIndex = 6;
            this.DugmePovratak.Text = "Povratak";
            this.DugmePovratak.UseVisualStyleBackColor = true;
            this.DugmePovratak.Click += new System.EventHandler(this.DugmePovratak_Click);
            // 
            // Rezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(550, 334);
            this.Controls.Add(this.DugmePovratak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rezultati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezultati";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DugmePovratak;
    }
}