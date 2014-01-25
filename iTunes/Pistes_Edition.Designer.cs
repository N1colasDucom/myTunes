namespace iTunes
{
    partial class Pistes_Edition
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
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Artiste = new System.Windows.Forms.Label();
            this.lbl_Album = new System.Windows.Forms.Label();
            this.tb_Titre = new System.Windows.Forms.TextBox();
            this.tb_Artiste = new System.Windows.Forms.TextBox();
            this.tb_Album = new System.Windows.Forms.TextBox();
            this.btn_EnregistrerModif = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.Location = new System.Drawing.Point(141, 34);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(41, 16);
            this.lbl_Titre.TabIndex = 1;
            this.lbl_Titre.Text = "Titre :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(22, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // lbl_Artiste
            // 
            this.lbl_Artiste.AutoSize = true;
            this.lbl_Artiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Artiste.Location = new System.Drawing.Point(141, 65);
            this.lbl_Artiste.Name = "lbl_Artiste";
            this.lbl_Artiste.Size = new System.Drawing.Size(51, 16);
            this.lbl_Artiste.TabIndex = 3;
            this.lbl_Artiste.Text = "Artiste :";
            // 
            // lbl_Album
            // 
            this.lbl_Album.AutoSize = true;
            this.lbl_Album.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Album.Location = new System.Drawing.Point(141, 96);
            this.lbl_Album.Name = "lbl_Album";
            this.lbl_Album.Size = new System.Drawing.Size(52, 16);
            this.lbl_Album.TabIndex = 4;
            this.lbl_Album.Text = "Album :";
            // 
            // tb_Titre
            // 
            this.tb_Titre.Location = new System.Drawing.Point(202, 33);
            this.tb_Titre.Name = "tb_Titre";
            this.tb_Titre.Size = new System.Drawing.Size(245, 20);
            this.tb_Titre.TabIndex = 5;
            // 
            // tb_Artiste
            // 
            this.tb_Artiste.Location = new System.Drawing.Point(202, 64);
            this.tb_Artiste.Name = "tb_Artiste";
            this.tb_Artiste.Size = new System.Drawing.Size(245, 20);
            this.tb_Artiste.TabIndex = 6;
            // 
            // tb_Album
            // 
            this.tb_Album.Location = new System.Drawing.Point(202, 95);
            this.tb_Album.Name = "tb_Album";
            this.tb_Album.Size = new System.Drawing.Size(245, 20);
            this.tb_Album.TabIndex = 7;
            // 
            // btn_EnregistrerModif
            // 
            this.btn_EnregistrerModif.Location = new System.Drawing.Point(344, 183);
            this.btn_EnregistrerModif.Name = "btn_EnregistrerModif";
            this.btn_EnregistrerModif.Size = new System.Drawing.Size(103, 28);
            this.btn_EnregistrerModif.TabIndex = 8;
            this.btn_EnregistrerModif.Text = "Enregistrer";
            this.btn_EnregistrerModif.UseVisualStyleBackColor = true;
            this.btn_EnregistrerModif.Click += new System.EventHandler(this.btn_EnregistrerModif_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(276, 183);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(62, 28);
            this.btn_Annuler.TabIndex = 9;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // Pistes_Edition
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 234);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_EnregistrerModif);
            this.Controls.Add(this.tb_Album);
            this.Controls.Add(this.tb_Artiste);
            this.Controls.Add(this.tb_Titre);
            this.Controls.Add(this.lbl_Album);
            this.Controls.Add(this.lbl_Artiste);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "Pistes_Edition";
            this.Text = "Pistes_Edition";
            this.Load += new System.EventHandler(this.Pistes_Edition_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Artiste;
        private System.Windows.Forms.Label lbl_Album;
        private System.Windows.Forms.TextBox tb_Titre;
        private System.Windows.Forms.TextBox tb_Artiste;
        private System.Windows.Forms.TextBox tb_Album;
        private System.Windows.Forms.Button btn_EnregistrerModif;
        private System.Windows.Forms.Button btn_Annuler;
    }
}